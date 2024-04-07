using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnTetromino : MonoBehaviour
{
    public GameObject[] Tetrominoes;
    public List<GameObject> ListTetrominoes;
    GameObject nextSpawn;
    GameObject targetSpawn;
    bool isFirst = true;

    //-------------
    SoundController soundController;

    void Start()
    {
        if (soundController == null)
            soundController = FindObjectOfType<SoundController>();
        Application.targetFrameRate = 60;
        ListTetrominoes = new List<GameObject>();
        soundController.PlaySound(SoundClip.GameStart);
        NewTetromino();
    }

    public void NewTetromino()
    {
        Invoke("createTetromino", 0.5f);
    }

    void createTetromino()
    {
        if (isFirst)
        {
            isFirst = false;
            targetSpawn = Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position, Quaternion.identity);
            ListTetrominoes.Add(targetSpawn);

            nextSpawn = Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], new Vector3(15.5f, 8f, 1f), Quaternion.identity);
            nextSpawn.GetComponent<TetrisBlock>().enabled = false;
            nextSpawn.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            targetSpawn = nextSpawn;
            targetSpawn.transform.position = transform.position;
            targetSpawn.transform.localScale = Vector3.one;
            targetSpawn.GetComponent<TetrisBlock>().enabled = true;
            ListTetrominoes.Add(targetSpawn);

            nextSpawn = null;
            nextSpawn = Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], new Vector3(15.5f, 8f, 1f), Quaternion.identity);
            nextSpawn.GetComponent<TetrisBlock>().enabled = false;
            nextSpawn.transform.localScale = new Vector3(1f, 1f, 1f);

            destoroyCheck();
        }
    }

    void destoroyCheck()
    {
        if (ListTetrominoes.Count > 0)
        {
            for (int i = 0; i < ListTetrominoes.Count; i++)
            {
                if (ListTetrominoes[i].transform.childCount == 0)
                {
                    Destroy(ListTetrominoes[i]);
                    ListTetrominoes.RemoveAt(i);
                }
            }
        }
    }
}