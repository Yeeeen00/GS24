using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class TetrisBlock : MonoBehaviour
{
    public Vector3 RotationPoint;
    public float FallTime = 0.8f;
    public static int Height = 20;
    public static int Width = 10;
    private float previousTime, previousTimeLeft, previousTimeRight;
    private static Transform[,] grid = new Transform[Width, Height];

    bool isGameOver;

    // other commponent ----------
    TouchButtons touchButtons;
    GameData gameData;
    SpawnTetromino spawTetromino;
    SoundController soundController;

    // vfx ----------
    [SerializeField] GameObject sparkPref;

    void Update()
    {
        if (touchButtons == null)
            touchButtons = FindObjectOfType<TouchButtons>();
        if (gameData == null)
            gameData = FindObjectOfType<GameData>();
        if (spawTetromino == null)
            spawTetromino = FindObjectOfType<SpawnTetromino>();
        if (soundController == null)
            soundController = FindObjectOfType<SoundController>();


        //=================== 키보드일 경우

        if ((Input.GetKey(KeyCode.LeftArrow) && Time.time - previousTimeLeft > (Input.GetKey(KeyCode.LeftArrow) ? FallTime / 8 : FallTime)))
            moveLeft();
        else if ((Input.GetKey(KeyCode.RightArrow) && Time.time - previousTimeRight > (Input.GetKey(KeyCode.RightArrow) ? FallTime / 8 : FallTime)))
            moveRight();
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rotateBlock();

        if (Time.time - previousTime > (Input.GetKey(KeyCode.DownArrow) ? FallTime / 14 : FallTime))
            moveDown();

        if (Input.GetKeyDown(KeyCode.Space)) // 터치
            dropBlock();

        //================== 터치일 경우
        if (touchButtons)
        {
            if (touchButtons.MyCommand == Command.Left && Time.time - previousTimeLeft > (touchButtons.MyCommand == Command.Left ? FallTime / 8 : FallTime))
                moveLeft();
            else if (touchButtons.MyCommand == Command.Right && Time.time - previousTimeRight > (touchButtons.MyCommand == Command.Right ? FallTime / 8 : FallTime))
                moveRight();
            else if (touchButtons.MyCommand == Command.Rotate)
                rotateBlock();

            if (touchButtons.MyCommand == Command.MoveDown)
                moveDown();

            if (touchButtons.MyCommand == Command.Down)
                dropBlock();
        }
    }

    void moveLeft()
    {
        // Left
        transform.position += new Vector3(-1, 0, 0);
        if (!ValidMove())
            transform.position -= new Vector3(-1, 0, 0);
        previousTimeLeft = Time.time;
    }
    void moveRight()
    {
        // Right
        transform.position += new Vector3(1, 0, 0);
        if (!ValidMove())
            transform.position -= new Vector3(1, 0, 0);
        previousTimeRight = Time.time;
    }
    void rotateBlock()
    {
        // Rotate!
        transform.RotateAround(transform.TransformPoint(RotationPoint), new Vector3(0, 0, 1), 90);
        if (this.tag == "Mino_I" || this.tag == "Mino_S" || this.tag == "Mino_Z") // 도는 범위가 넓어서 다시 잡아줌. 90도로 돌아갔다가 다시 원래 위치로
        {
            if (this.transform.localEulerAngles.z < 0 || this.transform.localEulerAngles.z > 90)
                this.transform.localEulerAngles = Vector3.zero;
        }
        else if (this.tag == "Mino_O") // 돌릴필요 없음
            this.transform.localEulerAngles = Vector3.zero;

        if (!ValidMove())
            transform.RotateAround(transform.TransformPoint(RotationPoint), new Vector3(0, 0, 1), -90);

        // 4개의 블록의 부모가 돌아가니 그림자가 돌아가는데 해당 블록들은 항상 그대로 있게 만들어준다.
        for (int i = 0; i < transform.childCount; i++)
            transform.GetChild(i).transform.rotation = Quaternion.identity;

    }
    void moveDown()
    {
        // Down
        transform.position += new Vector3(0, -1, 0);
        if (!ValidMove())
        {
            transform.position -= new Vector3(0, -1, 0);
            AddToGrid();
            checkForLines();
            this.enabled = false;
            if (!isGameOver)
                spawTetromino.NewTetromino();
        }
        previousTime = Time.time;
    }
    void dropBlock()
    {
        FallTime = 0;
    }

    /// <sammary>
    /// 10x20 그리드 전체 라인을 체크해서 가로라인이 만들어 질 경우 해당 라인을 삭제하고 아래로 내려준다. 그리고 몇줄의 라인이 만들어 졌는지 체크해서 점수를 준다.
    /// </sammary>
    void checkForLines()
    {
        int cnt = 0;
        for (int i = Height - 1; i >= 0; i--)
        {
            if (hasLine(i)) // 채워진 라인이 있는지 확인하고 있다면 삭제한 후 아래로 내려준다.
            {
                DeleteLine(i);
                RowDown(i);
                cnt++;
            }
        }
        if (cnt == 0)
        {
            soundController.PlaySound(SoundClip.Drop);
            gameData.Score += 10;
        }
        else
        {
            Debug.Log("deleted lines : " + cnt);
            // Score
            gameData.Score += cnt * 100;

            if (cnt == 4)
                soundController.PlaySound(SoundClip.Explo4);
            else
                soundController.PlaySound(SoundClip.Explo);
        }
    }

    /// <sammary>
    /// 해당 가로라인에 블록이 모두 있는지 없는지를 체크한다.
    /// </sammary>
    bool hasLine(int i)
    {
        for (int j = 0; j < Width; j++)
            if (grid[j, i] == null)
                return false;
        return true;
    }

    /// <sammary>
    /// 해당 라인을 삭제한다.
    /// </sammary>
    void DeleteLine(int i)
    {
        for (int j = 0; j < Width; j++)
        {
            Instantiate(sparkPref, grid[j, i].gameObject.transform.position, Quaternion.identity);
            Destroy(grid[j, i].gameObject);
            grid[j, i] = null;
        }
        // soundController.PlaySound(SoundClip.Explo);
    }

    /// <sammary>
    /// 해당 가로 라인이 비어있을 경우 아래로 내려준다
    /// </sammary>
    void RowDown(int i)
    {
        for (int y = i; y < Height; y++)
            for (int j = 0; j < Width; j++)
                if (grid[j, y] != null)
                {
                    grid[j, y - 1] = grid[j, y];
                    grid[j, y] = null;
                    grid[j, y - 1].transform.position -= new Vector3(0, 1, 0);
                }
    }

    /// <sammary>
    /// 10x20 그리드에 해당 블록을 채워 넣어줌 채울 수 없을 경우 게임 오버
    /// <sammary>
    void AddToGrid()
    {
        foreach (Transform children in transform)
        {
            int roundedX = Mathf.RoundToInt(children.transform.position.x);
            int roundedY = Mathf.RoundToInt(children.transform.position.y);

            if (roundedY < 20)
                grid[roundedX, roundedY] = children;
            else
                gameOver();

        }
    }

    /// <summary>
    /// 게임오버가 됐을 경우 띄우는 화면
    /// </summary>
    void gameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over@@");
        GameObject.FindWithTag("GameOver").gameObject.transform.GetChild(0).gameObject.SetActive(true);
        soundController.PlaySound(SoundClip.GameOver);
    }

    /// <summary>
    /// 10x20 그리드 안쪽에서 움직이고 있는지 아닌지를 판단
    /// </summary>
    bool ValidMove()
    {
        foreach (Transform children in transform)
        {
            int roundedX = Mathf.RoundToInt(children.transform.position.x);
            int roundedY = Mathf.RoundToInt(children.transform.position.y);

            if (roundedX < 0 || roundedX >= Width || roundedY < 0 || roundedY >= Height)
                return false;

            if (grid[roundedX, roundedY] != null)
                return false;
        }
        return true;
    }
}