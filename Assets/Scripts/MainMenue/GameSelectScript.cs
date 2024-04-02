using Match3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSelectScript : MonoBehaviour
{
    GameObject clickBtnObject;
    public Text gamename;
    public Text Scoretext;
    public Text Scoretext2;
    static Vector3 vector;
    public List<GameObject> GameBtn = new List<GameObject>();
    public static int arrnum = 0;
    bool Isrigthmove;
    bool Isleftmove;
    static int Gamecount = 0;
    private void Start(){
        if (Gamecount >= 1)
            GameObject.Find("GameIconBtn").transform.position = vector;
        Gamecount++;
    }
    public void StartBtnclick(){
        BtnClickSound.IsBtnClick = true;
        if(arrnum==0) SceneManager.LoadScene("Ai_gamestart");
        //if(arrnum==1)
        if(arrnum==2) SceneManager.LoadScene("Level01");
        if(arrnum==3) SceneManager.LoadScene("GomulgaWars");
        if(arrnum==4) SceneManager.LoadScene("Racing");
        if(arrnum==5) SceneManager.LoadScene("BIBIMBAB");
        //if(arrnum==6)
        if(arrnum==7) SceneManager.LoadScene("BlockCode");
    }
    public void ReCordButton()
    {
        BtnClickSound.IsBtnClick = true;
        Scoretext.text = "";
        Scoretext2.text = "";
        if (arrnum == 0){
            gamename.text = "에임 마스터즈";
            if (MovinTarget.AIM_SaveScore == 0){
                Scoretext.text = "아직 기록이 없습니다.";
                Scoretext2.text = "명중률 : 기록이 없습니다.";
            }
            else if (MovinTarget.AIM_SaveScore != 0){
                Scoretext.text = MovinTarget.AIM_SaveScore.ToString() + "점";
                Scoretext2.text="명중률 : "+MovinTarget.AIM_accuracyRateScore.ToString("F1")+"%";
            }
        }
        if (arrnum == 1) gamename.text = "한붓그리기";
        if (arrnum == 2){
            gamename.text = "카페인 어택";
            if (Hud.CA_SaveGameScore == 0)
                Scoretext.text = "아직 기록이 없습니다.";
            else if(Hud.CA_SaveGameScore != 0)
                Scoretext.text = Hud.CA_SaveGameScore.ToString() + "점";
        }
        if (arrnum == 3){
            gamename.text = "고물가 워즈";
            if (GO_PlayerScript.GO_SaveP_num == 0){
                Scoretext.text = "아직 기록이 없습니다.";
                Scoretext2.text = "스테이지 : 기록이 없습니다.";
            }
            else if (GO_PlayerScript.GO_SaveP_num != 0){
                Scoretext.text = GO_PlayerScript.GO_SaveP_num.ToString() + "점";
                Scoretext2.text = "스테이지 : " +GO_GameManager.GO_SaveStage.ToString();
            }
        }
        if (arrnum == 4){
            gamename.text = "우";
        }
        if (arrnum == 5){
            gamename.text = "비벼비벼비빔밥";
        }
        if (arrnum == 6) gamename.text = "테트리스";
        if (arrnum == 7){
            gamename.text = "야,너도할수있다!"+"\n"+ "도전! 특급 블록코딩" + "\n" +"~ 실전편 ~";
            if (score.B_SaveScore == 0)
                Scoretext.text = "아직 기록이 없습니다.";
            else if (score.B_SaveScore != 0)
                Scoretext.text = score.B_SaveScore.ToString() + "점";
        }
        
    }
    // Start is called before the first frame update
    void Right(){
        if (Isrigthmove != false){
            GameObject.Find("GameIconBtn").transform.position += new Vector3(-500, 0, 0);
            GameBtn[arrnum].transform.transform.localScale = new Vector3(1, 1);
            arrnum++;
        }
    }
    void Left(){
        if (Isleftmove != false){
            GameObject.Find("GameIconBtn").transform.position += new Vector3(500, 0, 0);
            GameBtn[arrnum].transform.transform.localScale = new Vector3(1, 1);
            arrnum--;
        }
    }
    public void RightArrowBtn(){
        BtnClickSound.IsBtnClick = true;
        if (Isrigthmove != false){
            GameObject.Find("GameIconBtn").transform.position += new Vector3(-500, 0, 0);
            GameBtn[arrnum].transform.transform.localScale = new Vector3(1, 1);
            arrnum++;
        }
    }
    public void LeftArrowBtn(){
        BtnClickSound.IsBtnClick = true;
        if (Isleftmove != false){
            GameObject.Find("GameIconBtn").transform.position += new Vector3(500, 0, 0);
            GameBtn[arrnum].transform.transform.localScale = new Vector3(1, 1);
            arrnum--;
        }
    }
    public void GameBtnOnClick(){
        BtnClickSound.IsBtnClick = true;
        clickBtnObject = EventSystem.current.currentSelectedGameObject;
        foreach (GameObject go in GameBtn){
            if (go.name == clickBtnObject.name){
                if (clickBtnObject.name == "GO")
                    SceneManager.LoadScene("GomulgaWars");
                if (clickBtnObject.name == "AIM")
                    SceneManager.LoadScene("Ai_gamestart");
                if (clickBtnObject.name == "BLE")
                    SceneManager.LoadScene("BlockCode");
                if (clickBtnObject.name == "WI")
                    SceneManager.LoadScene("Racing");
                if (clickBtnObject.name == "BI")
                    SceneManager.LoadScene("BIBIMBAB");
                if(clickBtnObject.name =="CA")
                    SceneManager.LoadScene("Level01");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        GameBtn[arrnum].transform.transform.localScale = new Vector3(1.7f, 1.7f);
        vector = GameObject.Find("GameIconBtn").transform.position;
        if (GameObject.Find("GameIconBtn").transform.position.x > -2500) { Isrigthmove = true; }
        if (GameObject.Find("GameIconBtn").transform.position.x <= -2500) { Isrigthmove = false; }
        if (GameObject.Find("GameIconBtn").transform.position.x < 500) { Isleftmove = true; }
        if (GameObject.Find("GameIconBtn").transform.position.x >= 500) { Isleftmove = false; }
        if (Input.GetKeyDown(KeyCode.RightArrow)) Right();
        if (Input.GetKeyDown(KeyCode.LeftArrow)) Left();
    }
}
