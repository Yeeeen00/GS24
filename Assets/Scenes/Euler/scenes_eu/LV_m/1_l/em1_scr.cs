using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using static SelScr;

public class em1_scr : MonoBehaviour
{
    public static em1_scr instance;
    public List<Image> objects = new List<Image>();
    [SerializeField] private GameObject tObj;
    private List<GameObject> lineObjects;
    public static bool isOn;

    private void Awake()
    {
        em1_scr.instance = this;
    }
    void Start()
    {
        SelScr.colorFinLine += changeColor;
        SelScr.checkIsCleared += OnCheckIsCleared;
        tObj.SetActive(false);
        lineObjects = new List<GameObject>();
        isOn = false;
        for (int i = 0; i < 8; i++)
        {
            drawStart(i);
        }
    }

    void Update()
    {
        drawUpdate(0, 0, 1);
        drawUpdate(1, 0, 2);
        drawUpdate(2, 0, 3);
        drawUpdate(3, 1, 2);
        drawUpdate(4, 1, 3);
        drawUpdate(5, 2, 4);
        drawUpdate(6, 3, 2);
        drawUpdate(7, 3, 4);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (isOn)
            {
                ResetScene();
            }
        }
        if (!isOn)
        {
            tObj.SetActive(false);
        }
    }
    void ResetScene()
    {
        //SceneManager.LoadScene("main_Eu");
        
        for (int i = 0; i < 8; i++)
        {
            lineObjects[i].GetComponent<LineRenderer>().material.color = Color.white;
        }
    }

    void OnCheckIsCleared()
    {
        bool allLinesRed = true;

        foreach (GameObject lineObject in lineObjects)
        {
            LineRenderer lineRenderer = lineObject.GetComponent<LineRenderer>();

            if (lineRenderer.material.color != Color.red)
            {
                allLinesRed = false;
                break;
            }
        }

        if (allLinesRed)
        {
            if(stageChoose_e.stClr < 1)
            {
                stageChoose_e.stClr = 1;
            }
            SceneManager.LoadScene("Euler_t");
        }
        else
        {
            tObj.SetActive(true);
            isOn = true;
        }
    }

    void changeColor(int n1, int n2)
    {
        for (int i = 0; i < 8; i++)
        {
            if ((lineObjects[i].GetComponent<LineRenderer>().GetPosition(0) == objects[n1].rectTransform.position && lineObjects[i].GetComponent<LineRenderer>().GetPosition(1) == objects[n2].rectTransform.position) || (lineObjects[i].GetComponent<LineRenderer>().GetPosition(0) == objects[n2].rectTransform.position && lineObjects[i].GetComponent<LineRenderer>().GetPosition(1) == objects[n1].rectTransform.position))
            {
                lineObjects[i].GetComponent<LineRenderer>().material.color = Color.red;
            }

        }
    }


    void drawStart(int numLine)
    {
        GameObject newLineObject = new GameObject("Line" + numLine);
        LineRenderer lineRenderer = newLineObject.AddComponent<LineRenderer>();

        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.widthMultiplier = 0.1f;
        lineRenderer.positionCount = 2;

        lineObjects.Add(newLineObject);
    }

    void drawUpdate(int numLine, int n1, int n2)
    {
        LineRenderer lineRenderer = lineObjects[numLine].GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, objects[n1].rectTransform.position);
        lineRenderer.SetPosition(1, objects[n2].rectTransform.position);
    }
}
