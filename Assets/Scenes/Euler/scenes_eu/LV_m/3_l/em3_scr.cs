using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using static SelScr3;

public class em3_scr : MonoBehaviour
{
    public static em3_scr instance;
    public List<Image> objects = new List<Image>();
    [SerializeField] private GameObject tObj;
    private List<GameObject> lineObjects;
    public bool isOn;

    private void Awake()
    {
        em3_scr.instance = this; 
    }
    void Start()
    {
        SelScr2.colorFinLine += changeColor;
        SelScr2.checkIsCleared += OnCheckIsCleared;
        tObj.SetActive(false);
        lineObjects = new List<GameObject>();
        isOn = false;
        for (int i = 0; i < 12; i++)
        {
            drawStart(i);
        }
    }

    void Update()
    {
        drawUpdate(0, 0, 1);
        drawUpdate(1, 0, 2);
        drawUpdate(2, 0, 3);
        drawUpdate(3, 0, 4);
        drawUpdate(4, 1, 4);
        drawUpdate(5, 2, 3);
        drawUpdate(6, 3, 4);
        drawUpdate(7, 3, 6);
        drawUpdate(8, 4, 6);
        drawUpdate(9, 2, 6);
        drawUpdate(10, 2, 5);
        drawUpdate(11, 6, 5);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(isOn) 
            { 
                ResetScene();
            }
        }
    }
    void ResetScene()
    {
        SceneManager.LoadScene("main_Eu");
        /*
        for (int i = 0; i < 8; i++)
        {
            lineObjects[i].GetComponent<LineRenderer>().material.color = Color.white;
        }*/
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
        for (int i = 0; i < 12; i++)
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
