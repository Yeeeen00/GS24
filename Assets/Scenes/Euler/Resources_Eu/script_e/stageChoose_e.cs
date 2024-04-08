using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stageChoose_e : MonoBehaviour
{
    public int stClr = 0;
    public int numNow;
    [SerializeField] private List<UnityEngine.UI.Image> p_image = new List<UnityEngine.UI.Image>();
    [SerializeField] private List<UnityEngine.UI.Image> c_image = new List<UnityEngine.UI.Image>();

    void Start()
    {
        numNow = 0;
        for (int i = 4; i > stClr; i--)
        {
            p_image[i].gameObject.SetActive(false);
        }
        for(int i = 4; i > 0; i--)
        {
            c_image[i].gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            UnityEngine.Debug.Log(numNow);
            if (numNow < stClr)
            {
                c_image[numNow].gameObject.SetActive(false);
                numNow++;
                c_image[numNow].gameObject.SetActive(true);
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (numNow != 0)
            {
                c_image[numNow].gameObject.SetActive(false);
                numNow--;
                c_image[numNow].gameObject.SetActive(true);
            }
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //SceneManager.LoadScene((char)(numNow+1)+"_em");
            switch (numNow)
            {
                case 0:
                    SceneManager.LoadScene("1_em");
                    break;

                case 1:
                    SceneManager.LoadScene("2_em");
                    break;

                case 2:
                    SceneManager.LoadScene("3_em");
                    break;

                case 3:
                    SceneManager.LoadScene("4_em");
                    break;

                case 4:
                    SceneManager.LoadScene("5_em");
                    break;

            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
    }

    void Quit()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}