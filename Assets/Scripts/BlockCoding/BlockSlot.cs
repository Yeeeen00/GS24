using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockSlot : MonoBehaviour
{
    [SerializeField]
    public List<BlockClone> itemList = new List<BlockClone>();

    [SerializeField]
    private Transform slotParent;
    [SerializeField]
    private Slot[] slots;

#if UNITY_EDITOR
    private void OnValidate()
    {
        slots = slotParent.GetComponentsInChildren<Slot>();
    }
#endif
    void Start()
    {
        FreshSlot();
    }

    public void initList()
    {
        if (itemList.Count > 0)
        {
            for (int i = itemList.Count; i > 0; i--)
            {
                DeleteItem();
            }
        }
    }
    public void FreshSlot()
    {
        int i = 0;
        for (; i < slots.Length; i++)
        {
            slots[i].block = null;
        }
        for (i = 0; i < itemList.Count && i < slots.Length; i++)
        {
            slots[i].block = itemList[i];
        }
    }

    public List<BlockClone> AddItem(BlockClone _item)
    {
        if (itemList.Count < slots.Length)
        {
            itemList.Add(_item);
        }
        else
        {
            print("슬롯이 가득 차 있습니다.");
        }
        return itemList;
    }

    public void DeleteItem()
    {
        itemList.Remove(itemList[itemList.Count - 1]);
        FreshSlot();
    }
  
}


/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    public List<Item> Inventory = new List<Item>();

    public ItemDatabase itemData;
    public Image image;
    public Sprite ClearImage;
    public TMP_Text text;

    public int preCount;
    // Start is called before the first frame update
    void Start()
    {
        itemData = GameObject.Find("ItemDatabase").GetComponent<ItemDatabase>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Inventory.Count == preCount)
        {
            Debug.Log("변동 없음");
        }
        else
        {
            preCount = Inventory.Count;
            addItem();
            deleteItem();
            ShowInventory();
            
        }
    }
    public void addItem()
    {
        Debug.Log("추가됨");
        for (int i = 1; i < itemData.itemDB.Count; i++)
        {

            if (itemData.itemDB[i].count > 0)
            {
                if (Inventory.Contains(itemData.itemDB[i]))
                {
                    Debug.Log("중복");
                }
                else
                {
                    Item item = new Item();
                    item.ItemName = itemData.itemDB[i].ItemName;
                    item.category = itemData.itemDB[i].category;
                    item.ItemImage = itemData.itemDB[i].ItemImage;
                    item.UnLocked = itemData.itemDB[i].UnLocked;
                    item.count = itemData.itemDB[i].count;
                    item.ItemNumber = itemData.itemDB[i].ItemNumber;
                    item.recipy = itemData.itemDB[i].recipy;
                    Inventory.Add(item);
                }
            }
        }
    }
    public void deleteItem()
    {
        for (int i = 0; i < Inventory.Count; i++)
        {
            if (Inventory[i].count <= 0)
            {
                Inventory.RemoveAt(i);
            }
        }
    }
    public void ShowInventory()
    {
        int n = 0;
        for (int i = 1; i < Inventory.Count; i++)
        {
            string ObjName = "slot (" + n + ")";
            image = GameObject.Find(ObjName).transform.Find("Image").GetComponent<Image>();
            text = GameObject.Find(ObjName).transform.Find("Text").GetComponent<TMP_Text>();

            image.sprite = ClearImage;
            text.text = "   ";
        }
            
        for (int i = 1; i < Inventory.Count; i++)
        {
            
            string ObjName = "slot (" + n + ")";
            image = GameObject.Find(ObjName).transform.Find("Image").GetComponent<Image>();
            text = GameObject.Find(ObjName).transform.Find("Text").GetComponent<TMP_Text>();

            image.sprite = Inventory[i].ItemImage;
            text.text = Inventory[i].count.ToString();
            n++;
        }
    }
}
*/