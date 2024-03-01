using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GO_ChangeImage : MonoBehaviour
{
    public Sprite[] EnemyImage;
    Image image;
    public int EnemyAni;
    // Start is called before the first frame update
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    void Start()
    {
        if (EnemyAni == 0){
            InvokeRepeating("Bisket", 0.5f, 1);
        }
        if (EnemyAni == 1){
            InvokeRepeating("Samgak", 0.5f, 1);
        }
        if (EnemyAni == 2){
            InvokeRepeating("Water", 0.5f, 1);
        }
        if (EnemyAni == 3){
            InvokeRepeating("choco", 0.5f, 1);
        }
        if (EnemyAni == 4){
            InvokeRepeating("chip", 0.5f, 1);
        }
        if (EnemyAni == 5){
            InvokeRepeating("sand", 0.5f, 1);
        }
        if (EnemyAni == 6){
            InvokeRepeating("cola", 0.5f, 1);
        }
        if (EnemyAni == 7){
            InvokeRepeating("hotdog", 0.5f, 1);
        }
        if (EnemyAni == 8){
            InvokeRepeating("hambug", 0.5f, 1);
        }
        if (EnemyAni == 9){
            InvokeRepeating("ramyun", 0.5f, 1);
        }
        if (EnemyAni == 10){
            InvokeRepeating("pizza", 0.5f, 1);
        }
    }
    void Bisket(){
        image.sprite = EnemyImage[0];
        Invoke("Bisket1", 0.5f);
    }
    void Bisket1(){
        image.sprite = EnemyImage[1];
    }
    void Samgak()
    {
        image.sprite = EnemyImage[2];
        Invoke("Samgak1", 0.5f);
    }
    void Samgak1()
    {
        image.sprite = EnemyImage[3];
    }
    void Water()
    {
        image.sprite = EnemyImage[4];
        Invoke("Water1", 0.5f);
    }
    void Water1()
    {
        image.sprite = EnemyImage[5];
    }
    void choco()
    {
        image.sprite = EnemyImage[6];
        Invoke("choco1", 0.5f);
    }
    void choco1()
    {
        image.sprite = EnemyImage[7];
    }
    void chip()
    {
        image.sprite = EnemyImage[8];
        Invoke("chip1", 0.5f);
    }
    void chip1()
    {
        image.sprite = EnemyImage[9];
    }
    void sand()
    {
        image.sprite = EnemyImage[10];
        Invoke("sand1", 0.5f);
    }
    void sand1()
    {
        image.sprite = EnemyImage[11];
    }
    void cola()
    {
        image.sprite = EnemyImage[12];
        Invoke("cola1", 0.5f);
    }
    void cola1()
    {
        image.sprite = EnemyImage[13];
    }
    void hotdog()
    {
        image.sprite = EnemyImage[14];
        Invoke("hotdog1", 0.5f);
    }
    void hotdog1()
    {
        image.sprite = EnemyImage[15];
    }
    void hambug()
    {
        image.sprite = EnemyImage[16];
        Invoke("hambug1", 0.5f);
    }
    void hambug1()
    {
        image.sprite = EnemyImage[17];
    }
    void ramyun()
    {
        image.sprite = EnemyImage[18];
        Invoke("ramyun1", 0.5f);
    }
    void ramyun1()
    {
        image.sprite = EnemyImage[19];
    }
    void pizza()
    {
        image.sprite = EnemyImage[20];
        Invoke("pizza1", 0.5f);
    }
    void pizza1()
    {
        image.sprite = EnemyImage[21];
    }
}
