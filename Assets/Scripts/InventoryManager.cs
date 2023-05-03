using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();
    public static int itemsCount;

    public Transform ItemContent;
    public GameObject InventoryItem;
    public GameObject InventoryFullPanel;

    public InventoryItemController[] InventoryItems;

    public static bool hoeSelected;
    public static bool shovelSelected;
    public static bool watercanSelected;
    public static bool scissorsSelected;
    public static bool sickleSelected;

    private void Awake()
    {
        Instance = this;

    }

    public void Add(Item item)
    {
        if(InventoryManager.itemsCount <= 2)
        {
            Items.Add(item);
        }
        else
        {
            InventoryFullPanel.SetActive(true);
        }
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public void ListItems()
    {
        foreach(Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            var removeButton = obj.transform.Find("RemoveButton").GetComponent<Button>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.itemIcon;
            removeButton.gameObject.SetActive(true);
        }
        //SetInventoryItems();
    }

    /*public void SetInventoryItems()
    {
        InventoryItems = ItemContent.GetComponentsInChildren<InventoryItemController>();
        for(int i = 0; i < Items.Count; i++)
        {
            Debug.Log(i);
            Debug.Log(ItemContent);
            InventoryItems[i].AddItem(Items[i]);
        }
    } */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ListItems();
        itemsCount = Items.Count;
    }
}
