using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Item item;
    public GameObject InventoryFullPanel;

    void Pickup()
    {
        if(InventoryManager.itemsCount <= 2){
            InventoryManager.Instance.Add(item);
            
            if(gameObject.tag == "hoe")
            {
                InventoryManager.hoeSelected = true;
            }
            else if(gameObject.tag == "shovel")
            {
                InventoryManager.shovelSelected = true;
            }
            else if(gameObject.tag == "water can")
            {
                InventoryManager.watercanSelected = true;
            }
            else if(gameObject.tag == "scissors")
            {
                InventoryManager.scissorsSelected = true;
            }
            else if(gameObject.tag == "sickle")
            {
                InventoryManager.sickleSelected = true;
            }
        }
        else
        {
            InventoryFullPanel.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        Pickup();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
