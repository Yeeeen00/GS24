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


        //=================== Ű������ ���

        if ((Input.GetKey(KeyCode.LeftArrow) && Time.time - previousTimeLeft > (Input.GetKey(KeyCode.LeftArrow) ? FallTime / 8 : FallTime)))
            moveLeft();
        else if ((Input.GetKey(KeyCode.RightArrow) && Time.time - previousTimeRight > (Input.GetKey(KeyCode.RightArrow) ? FallTime / 8 : FallTime)))
            moveRight();
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rotateBlock();

        if (Time.time - previousTime > (Input.GetKey(KeyCode.DownArrow) ? FallTime / 14 : FallTime))
            moveDown();

        if (Input.GetKeyDown(KeyCode.Space)) // ��ġ
            dropBlock();

        //================== ��ġ�� ���
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
        if (this.tag == "Mino_I" || this.tag == "Mino_S" || this.tag == "Mino_Z") // ���� ������ �о �ٽ� �����. 90���� ���ư��ٰ� �ٽ� ���� ��ġ��
        {
            if (this.transform.localEulerAngles.z < 0 || this.transform.localEulerAngles.z > 90)
                this.transform.localEulerAngles = Vector3.zero;
        }
        else if (this.tag == "Mino_O") // �����ʿ� ����
            this.transform.localEulerAngles = Vector3.zero;

        if (!ValidMove())
            transform.RotateAround(transform.TransformPoint(RotationPoint), new Vector3(0, 0, 1), -90);

        // 4���� ����� �θ� ���ư��� �׸��ڰ� ���ư��µ� �ش� ��ϵ��� �׻� �״�� �ְ� ������ش�.
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
    /// 10x20 �׸��� ��ü ������ üũ�ؼ� ���ζ����� ����� �� ��� �ش� ������ �����ϰ� �Ʒ��� �����ش�. �׸��� ������ ������ ����� ������ üũ�ؼ� ������ �ش�.
    /// </sammary>
    void checkForLines()
    {
        int cnt = 0;
        for (int i = Height - 1; i >= 0; i--)
        {
            if (hasLine(i)) // ä���� ������ �ִ��� Ȯ���ϰ� �ִٸ� ������ �� �Ʒ��� �����ش�.
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
    /// �ش� ���ζ��ο� ����� ��� �ִ��� �������� üũ�Ѵ�.
    /// </sammary>
    bool hasLine(int i)
    {
        for (int j = 0; j < Width; j++)
            if (grid[j, i] == null)
                return false;
        return true;
    }

    /// <sammary>
    /// �ش� ������ �����Ѵ�.
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
    /// �ش� ���� ������ ������� ��� �Ʒ��� �����ش�
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
    /// 10x20 �׸��忡 �ش� ����� ä�� �־��� ä�� �� ���� ��� ���� ����
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
    /// ���ӿ����� ���� ��� ���� ȭ��
    /// </summary>
    void gameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over@@");
        GameObject.FindWithTag("GameOver").gameObject.transform.GetChild(0).gameObject.SetActive(true);
        soundController.PlaySound(SoundClip.GameOver);
    }

    /// <summary>
    /// 10x20 �׸��� ���ʿ��� �����̰� �ִ��� �ƴ����� �Ǵ�
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