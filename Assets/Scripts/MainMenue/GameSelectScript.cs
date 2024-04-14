using Match3;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSelectScript : MonoBehaviour
{
    GameObject clickBtnObject;
    public Text Extxt;
    public Text Game_Name;
    public Text gamename;
    public Text Scoretext;
    public Text Scoretext2;
    public Text name1;
    public Text name2;
    public Text name3;
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
        if (arrnum == 1) SceneManager.LoadScene("main_Eu");
        if(arrnum==2) SceneManager.LoadScene("Level01");
        if(arrnum==3) SceneManager.LoadScene("GomulgaWars");
        if(arrnum==4) SceneManager.LoadScene("Racing");
        if(arrnum==5) SceneManager.LoadScene("BIBIMBAB");
        if(arrnum==6) SceneManager.LoadScene("Tetris");
        if(arrnum==7) SceneManager.LoadScene("BlockCode");
    }
    public void ExPlainFunc()
    {
        if (arrnum == 0)
        {
            Game_Name.text = "에임 마스터즈";
            Extxt.text = "마우스를 이용하여 랜덤하게 등장하는 "+"\n\n"+ "과녁을 맞춰라!! 잘못클릭하면 명중률이"+"\n\n"+" 떨어지고 과녁의 위치가 또 바뀌니 주의!!";
        }
        if (arrnum == 1)
        {
            Game_Name.text = "한붓그리기";
            Extxt.text = "퍼즐장르의 두뇌게임!"+"\n\n"+ "키보드 화살표키로 가고싶은 점을 선택한뒤"+"\n\n"+ "Enter를 눌러 점끼리 연결시켜라!!" + "\n\n"+ "한번 이어진 점으로는 다시 이동할수 없다! " + "\n\n"+"모든점을 연결하라!!";
        }
        if (arrnum == 2)
        {
            Game_Name.text = "카페인 어택";
            Extxt.text = "카페인 음료를 사수하라!!"+"\n\n"+"똑같은 음료를 한줄로 맞추면 "+"\n\n"+"점수를 얻는다!! 마우스로 직접 옮겨서"+"\n\n"+"횟수안에 최대한 많은 점수를 휙득하라!!";
        }
        if (arrnum == 3)
        {
            Game_Name.text = "고물가 워즈";
            Extxt.text = "광고에 맨날 나오는 바로 그 게임!"+"\n\n"+"왼쪽 아래 캐릭터를 본인보다 숫자가 작은"+"\n\n"+"물건으로 가져다 놓아 공격하자!"+"\n\n"+"힘을 키워서 모든 물건을 없에버리자!!!";
        }
        if (arrnum == 4)
        {
            Game_Name.text = "윙";
            Extxt.text = "최대한 빠른 시간안에 결승점을 통과하라!!"+"\n\n"+"키보드 화살표키로 조작하여 플레이하는 "+"\n\n"+"레이실 게임!! 빠르게 한바퀴를 돌면 성공!!";
        }
        if (arrnum == 5)
        {
            Game_Name.text = "비벼비벼비빔밥";
            Extxt.text = "추억의 고향만두 게임을 비빔밥 버전으로!!"+"\n\n"+"원하는 재료를 넣어서 최고의 비빔밥을"+"\n\n"+" 완성시키자!!";
        }
        if (arrnum == 6)
        {
            Game_Name.text = "테트리스";
            Extxt.text = "편의의 각종물품들로 플레이하는"+"\n\n"+"테트리스!! 키보드 화살표 좌우키로" +"\n\n" +"조작가능하고 화살표 위로가기키를 누르면"+"\n\n"+"회전한다! C키를 누를시 블럭 저장이 "+"\n\n"+"가능하고 SpaceBar누르면 바로 떨어진다!!";
        }
        if (arrnum == 7)
        {
            Game_Name.text = "야,너도할수있다!" + "\n" + "도전! 특급 블록코딩" + "\n" + "~ 실전편 ~";
            Extxt.text = "여러분도 할수있습니다."+"\n\n"+"주어진 상황을 블록코딩을 이용하여"+"\n\n"+"해결하라!! 문제가 어렵다면 게임에"+"\n\n"+"나와있는 답지를 확인할수있다!";
        }
    }
    public void DeveloperButton()
    {
        if(arrnum == 0)
        {
            name1.text = "박태환";
            name2.text = "박태환";
            name3.text = "박태환";
        }
        if (arrnum == 1)
        {
            name1.text = "민혜은";
            name2.text = "민혜은,이효린";
            name3.text = "민혜은";
        }
        if (arrnum == 2)
        {
            name1.text = "구원";
            name2.text = "허지하";
            name3.text = "정민재";
        }
        if (arrnum == 3)
        {
            name1.text = "민지명";
            name2.text = "이도현";
            name3.text = "이도현";
        }
        if (arrnum == 4)
        {
            name1.text = "박성현";
            name2.text = "박성현";
            name3.text = "박성현";
        }
        if (arrnum == 5)
        {
            name1.text = "홍기웅";
            name2.text = "우세람";
            name3.text = "홍기웅";
        }
        if (arrnum == 6)
        {
            name1.text = "예은우";
            name2.text = "이효린";
            name3.text = "윤다희";
        }
        if (arrnum == 7)
        {
            name1.text = "허지하";
            name2.text = "허지하";
            name3.text = "허지하";
        }
    }
    public void ReCordButton()
    {
        Scoretext.text = "";
        Scoretext2.text = "";
        if (arrnum == 0){
            gamename.text = "에임 마스터즈";
            if (gameoverscene.AIM_SaveScore == 0){
                Scoretext.text = "아직 기록이 없습니다.";
                Scoretext2.text = "명중률 : 기록이 없습니다.";
            }
            else if (gameoverscene.AIM_SaveScore != 0){
                Scoretext.text = gameoverscene.AIM_SaveScore.ToString() + "점";
                Scoretext2.text="명중률 : "+gameoverscene.AIM_accuracyRateScore.ToString("F1")+"%";
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
            gamename.text = "윙";
            if (checkpiints.SaveTimer == 100000f)
                Scoretext.text = "아직 기록이 없습니다.";
            if(checkpiints.SaveTimer != 100000f)
                Scoretext.text=checkpiints.SaveTimer.ToString("F3")+"초 완주";
        }
        if (arrnum == 5){
            gamename.text = "비벼비벼비빔밥";
            if(BI_ButtonManager.BI_SavePoint == 0) { Scoretext.text = "아직 기록이 없습니다."; }
            else if(BI_ButtonManager.BI_SavePoint != 0){
                if (BI_ButtonManager.BI_SavePoint > 5)
                    Scoretext.text = "비빔밥의 맛은 환상적이다!";
                else if (BI_ButtonManager.BI_SavePoint < 5)
                    Scoretext.text = "비빔밥의 맛은 충격적이다...!";
            }
        }
        if (arrnum == 6)
        {
            gamename.text = "테트리스";
            if(GameOver.Te_SaveScore==0){
                Scoretext.text = "아직 기록이 없습니다.";
            }
            else if(GameOver.Te_SaveScore!=0)
            {
                Scoretext.text=GameOver.Te_SaveScore.ToString() + "점";
            }
        }
        if (arrnum == 7){
            gamename.text = "야,너도할수있다!"+"\n"+ "도전! 특급 블록코딩" + "\n" +"~ 실전편 ~";
            if (score.B_SaveScore == 0)
                Scoretext.text = "아직 기록이 없습니다.";
            else if (score.B_SaveScore != 0)
                Scoretext.text = score.B_SaveScore.ToString() + "점";
        }
        
    }
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
                if (clickBtnObject.name == "TE")
                    SceneManager.LoadScene("Tetris");
                if((clickBtnObject.name =="HAN"))
                    SceneManager.LoadScene("main_Eu");
            }
        }
    }
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
