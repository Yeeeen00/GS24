using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SelScr3 : MonoBehaviour
{
    public delegate void IntValuesDelegate(int value1, int value2);
    public static event IntValuesDelegate colorFinLine;
    public delegate void CheckIsCleared();
    public static event CheckIsCleared checkIsCleared;
    public int numTemp;
    public int numNow;
    public List<List<int>> finNum;
    public List<List<int>> linkedNum;
    [SerializeField] private List<UnityEngine.UI.Image> c_image = new List<UnityEngine.UI.Image>();

    void Start()
    {
        numNow = 0;
        numTemp = 1;

        for (int i = 6; i > 1; i--)
        {
            c_image[i].gameObject.SetActive(false);
        }

        linkedNum = new List<List<int>>();
        for (int i = 0; i < 7; i++)
        {
            linkedNum.Add(new List<int>());
        }
        linkedNum[0] = new List<int> { 1, 2, 3, 4 };
        linkedNum[1] = new List<int> { 0, 4 };
        linkedNum[2] = new List<int> { 0, 4, 5, 6 };
        linkedNum[3] = new List<int> { 0, 2, 4, 6 };
        linkedNum[4] = new List<int> { 0, 1, 3, 6 };
        linkedNum[5] = new List<int> { 2, 6 };
        linkedNum[6] = new List<int> { 2, 3, 4, 5 };

        finNum = new List<List<int>>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (nextNumLinked(numNow, numTemp) != -1)
            {
                UnityEngine.Debug.Log(numTemp);
                c_image[numTemp].gameObject.SetActive(false);
                numTemp = linkedNum[numNow][nextNumLinked(numNow, numTemp)];
                c_image[numTemp].gameObject.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (preNumLinked(numNow, numTemp) != -1)
            {
                c_image[numTemp].gameObject.SetActive(false);
                numTemp = linkedNum[numNow][preNumLinked(numNow, numTemp)];
                c_image[numTemp].gameObject.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (em3_scr.isOn)
            {
                numNow = 0;
                numTemp = 1;

                for (int i = 6; i > 1; i--)
                {
                    c_image[i].gameObject.SetActive(false);
                }

                finNum = new List<List<int>>();
                em3_scr.isOn = false;
            }

            c_image[numNow].gameObject.SetActive(false);
            finNum.Add(new List<int> { numNow, numTemp });
            c_image[numTemp].gameObject.SetActive(true);
            colorFinLine?.Invoke(numTemp, numNow);
            numNow = numTemp;
            //if (nextNumLinked(numNow, numTemp) != -1) { numTemp = linkedNum[numNow][nextNumLinked(numNow, numTemp)]; }
            //else if (preNumLinked(numNow, numTemp) != -1) { numTemp = linkedNum[numNow][preNumLinked(numNow, numTemp)]; }

            /*
            if (em1_scr.instance.isOn)
            {
                finNum = new List<List<int>>();
                UnityEngine.Debug.Log(finNum[0][0]);
            }*/
            if (preNumLinked(numNow, numTemp) == -1 && nextNumLinked(numNow, numTemp) == -1)
            {
                checkIsCleared?.Invoke();
            }
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
    }

    void Quit()
    {
        SceneManager.LoadScene("Euler_t");
    }

    bool isFin(int num1, int num2)
    {
        for (int i = 0; i < finNum.Count; i++)
        {
            if ((finNum[i][0] == num1 && finNum[i][1] == num2) || (finNum[i][0] == num2 && finNum[i][1] == num1))
            {
                return true;
            }
        }
        return false;
    }

    int nextNumLinked(int num, int t)
    {
        for (int i = 0; i < linkedNum[num].Count; i++)
        {
            if ((linkedNum[num][i] > t) && !isFin(numNow, linkedNum[num][i]))
            {
                return i;
            }
        }
        return -1;
    }
    int preNumLinked(int num, int t)
    {
        for (int i = linkedNum[num].Count - 1; i >= 0; i--)
        {
            if ((linkedNum[num][i] < t) && !isFin(numNow, linkedNum[num][i]))
            {
                return i;
            }
        }
        return -1;
    }
}