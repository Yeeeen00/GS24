using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class LineStageChoose : MonoBehaviour
{
    public List<Image> c_objects = new List<Image>();
    private List<GameObject> lineObjects;

    void Start()
    {
        lineObjects = new List<GameObject>();
        for (int i = 0; i < 6; i++)
        {
            drawStart(i);
        }
    }

    void Update()
    {
        drawUpdate(0, 0, 1);
        drawUpdate(1, 1, 2);
        drawUpdate(2, 2, 3);
        drawUpdate(3, 3, 4);
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
        lineRenderer.SetPosition(0, c_objects[n1].rectTransform.position);
        lineRenderer.SetPosition(1, c_objects[n2].rectTransform.position);
    }
}
