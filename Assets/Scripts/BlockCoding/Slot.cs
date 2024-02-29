using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Slot : MonoBehaviour
{
    [SerializeField] Image image;
    public Image image2;
    public TMP_Text text;
    private BlockClone _item;

    private BlockList BL;
    void Awake()
    {
        image2 = transform.GetChild(0).gameObject.GetComponent<Image>();
        text = transform.GetChild(1).gameObject.GetComponent<TMP_Text>();

        BL = GameObject.Find("subBlock").GetComponent<BlockList>();


    }


    public BlockClone block
    {
        get { return _item; }
        set
        {
            _item = value;
            if (_item != null)
            {
                Debug.Log(block.Image);
                image.sprite = block.Image;
                Debug.Log(image.sprite);
                image.color = new Color(1, 1, 1, 1);

                if (_item.Name == "입력문" || _item.Name == "기다리기문" || _item.Name == "반복문조건")
                {
                    image2.sprite = BL.subBlock[19].Image;
                    image2.color = new Color(1, 1, 1, 1);

                    text.text = _item.index.ToString();
                    
                }
                else text.text = "  ";

                if (_item.Name == "반복문전체" || _item.Name == "반복문끝" || _item.Name == "조건문끝" || _item.Name == "끝") image2.color = new Color(1, 1, 1, 0);
                else
                {
                    subImageSet();
                    image2.color = new Color(1, 1, 1, 1);
                }
            }
            else
            {
                image.color = new Color(1, 1, 1, 0);
                image2.color = new Color(1, 1, 1, 0);
                text.text = "  ";
            }
        }
    }
    public void subImageSet()
    {
        switch (_item.index)
        {
            case 10: image2.sprite = BL.subBlock[0].Image; break;
            case 20: image2.sprite = BL.subBlock[1].Image; break;
            case 30: image2.sprite = BL.subBlock[2].Image; break;
            case 40: image2.sprite = BL.subBlock[3].Image; break;
            case 50: image2.sprite = BL.subBlock[4].Image; break;
            case 60: image2.sprite = BL.subBlock[5].Image; break;
            case 70: image2.sprite = BL.subBlock[6].Image; break;
            case 80: image2.sprite = BL.subBlock[7].Image; break;
            case 90: image2.sprite = BL.subBlock[8].Image; break;
            case 100: image2.sprite = BL.subBlock[9].Image; break;
            case 110: image2.sprite = BL.subBlock[10].Image; break;
            case 120: image2.sprite = BL.subBlock[11].Image; break;
            case 130: image2.sprite = BL.subBlock[12].Image; break;
            case 140: image2.sprite = BL.subBlock[13].Image; break;
            case 150: image2.sprite = BL.subBlock[14].Image; break;
            case 160: image2.sprite = BL.subBlock[15].Image; break;
            case 170: image2.sprite = BL.subBlock[16].Image; break;
            case 180: image2.sprite = BL.subBlock[17].Image; break;
            case 190: image2.sprite = BL.subBlock[18].Image; break;

        }

    }
}
