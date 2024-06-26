using System;
using System.Collections;
using System.Collections.Generic;
using Inventory.Model;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PickUpSystem : MonoBehaviour
{
    [SerializeField]
    private InventorySO inventoryData;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item item = collision.GetComponent<Item>();
        if(item != null)
        {
            int remainder = inventoryData.AddItem(item.InventoryItem, item.Quantity);
            if(remainder == 0)
                item.DestroyItem();
            else
                item.Quantity = remainder;
        }
    }
}
