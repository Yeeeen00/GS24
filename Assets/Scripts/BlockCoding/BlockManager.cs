using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BlockManager : MonoBehaviour
{
    public Block block;
    
    public BlockSlot bSlot;
    public BlockClone B = new BlockClone();


    public GameObject codingGround;
    public GameObject IfWindow;
    public GameObject MoveWindow;
    public GameObject ActionWindow;
    public GameObject InputWindow1;
    public GameObject InputWindow2;
    public GameObject InputWindow3;

    public GameObject Fld;
    public TMP_InputField field;
   


    public int idx;

    private void Awake()
    {
        field = Fld.GetComponent<TMP_InputField>();

    }

    // Start is called before the first frame update
    void Start()
    {
        //bSlot = GetComponent<BlockSlot>();
        if (gameObject.tag != "Sub")
            SetBlock();

    }
    public void SetBlock()
    {
        Image image;
        image = this.GetComponent<Image>();

        image.sprite = block.Image;
        RectTransform Wh;

        Wh = this.transform.GetComponent<RectTransform>();
        Wh.sizeDelta = new Vector2(block.Image.rect.width, block.Image.rect.height);
    }
    public BlockClone clone()
    {
        B.Image = block.Image;
        Debug.Log(B.Image);
        B.index = block.index;
        B.Name = block.Name;
        B.type = block.type;

        return B;
    }
    public void ClickMouse()
    {
        
        if (gameObject.tag == "Btn")
        {
            clone();
            bSlot.AddItem(B);
            bSlot.FreshSlot();
        }
        else
        {
            subClick();
            
        }
    }
    public void subClick()
    {
        if(gameObject.tag == "If")
        {
            clone();
            IfWindow.SetActive(true);
            MoveWindow.SetActive(false);
            ActionWindow.SetActive(false);
            InputWindow1.SetActive(false);
            InputWindow2.SetActive(false);
            InputWindow3.SetActive(false);
        }
        else if (gameObject.tag == "Move")
        {
            clone();
            IfWindow.SetActive(false);
            MoveWindow.SetActive(true);
            ActionWindow.SetActive(false);
            InputWindow1.SetActive(false);
            InputWindow2.SetActive(false);
            InputWindow3.SetActive(false);
        }
        else if (gameObject.tag == "Action")
        {
            clone();
            IfWindow.SetActive(false);
            MoveWindow.SetActive(false);
            ActionWindow.SetActive(true);
            InputWindow1.SetActive(false);
            InputWindow2.SetActive(false);
            InputWindow3.SetActive(false);
        }
        else if (gameObject.tag == "Input1")
        {
            IfWindow.SetActive(false);
            MoveWindow.SetActive(false);
            ActionWindow.SetActive(false);
            InputWindow1.SetActive(true);
            InputWindow2.SetActive(false);
            InputWindow3.SetActive(false);

            //input();
        }
        else if (gameObject.tag == "Input2")
        {
            IfWindow.SetActive(false);
            MoveWindow.SetActive(false);
            ActionWindow.SetActive(false);
            InputWindow1.SetActive(false);
            InputWindow2.SetActive(true);
            InputWindow3.SetActive(false);

            //input();
        }
        else if (gameObject.tag == "input3")
        {
            IfWindow.SetActive(false);
            MoveWindow.SetActive(false);
            ActionWindow.SetActive(false);
            InputWindow1.SetActive(false);
            InputWindow2.SetActive(false);
            InputWindow3.SetActive(true);

            //input();
        }

    }
    public void SetSubBlock()
    {
        clone();
        B.index = idx;
        bSlot.AddItem(B);
        bSlot.FreshSlot();
    }
    public void input()
    {
        
        clone();
        string text = field.text;
        B.index = int.Parse(text);
        bSlot.AddItem(B);
        bSlot.FreshSlot();
    }

    
}