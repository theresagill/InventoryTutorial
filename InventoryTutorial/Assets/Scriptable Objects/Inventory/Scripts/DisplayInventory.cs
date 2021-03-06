﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    //public GameObject inventoryPrefab;
    public InventoryObject inventory;
    public int X_SPACE_BETWEEN_ITEMS;
    public int NUMBER_OF_COLUMN;
    public int Y_SPACE_BETWEEN_ITEMS;
    public int X_START;
    public int Y_START;
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        CreateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDisplay();
    }
    //public void CreateDisplay()
    //{
    //    for (int i = 0; i < inventory.Container.Items.Count; i++)
    //    {
    //        InventorySlot slot = inventory.Container.Items[i];

    //        var obj = Instantiate(inventoryPrefab, Vector3.zero, Quaternion.identity, transform);
    //        //var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero,Quaternion.identity,transform);
    //        obj.transform.GetChild(0).GetComponentInChildren<Image>().sprite =
    //                inventory.database.GetItem[slot.item.Id].uiDisplay;


     //       obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
     //       obj.GetComponentInChildren<TextMeshProUGUI>().text = slot.amount.ToString("n0");
     //       itemsDisplayed.Add(slot, obj);


      //  }
    //}
    public void CreateDisplay()
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero,Quaternion.identity,transform);
            
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            obj.GetComponentInChildren<TextMeshProUGUI>().text = inventory.Container[i].amount.ToString("n0");
            itemsDisplayed.Add(inventory.Container[i], obj);

        }
    }
    public Vector3 GetPosition(int i)
    {
        return new Vector3(X_START + (X_SPACE_BETWEEN_ITEMS * (i % NUMBER_OF_COLUMN)),
        Y_START +
        (-Y_SPACE_BETWEEN_ITEMS * (i / NUMBER_OF_COLUMN)), 0f);
    }
    //public void UpdateDisplay()
    //{
    //    for (int i = 0; i < inventory.Container.Items.Count; i++)
    //    {
    //        InventorySlot slot = inventory.Container.Items[i];

    //        if (itemsDisplayed.ContainsKey(slot))
    //        {
    //            itemsDisplayed[slot].GetComponentInChildren<TextMeshProUGUI>().text
    //                = slot.amount.ToString("n0");
    //        }
    //        else
    //        {
    //            var obj = Instantiate(inventoryPrefab, Vector3.zero, Quaternion.identity, transform);
    //            obj.transform.GetChild(0).GetComponentInChildren<Image>().sprite =
    //                inventory.database.GetItem[slot.item.Id].uiDisplay;

    //            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
    //            obj.GetComponentInChildren<TextMeshProUGUI>().text = slot.amount.ToString("n0");
    //            itemsDisplayed.Add(slot, obj);
    //        }

    //    }
    //}
    public void UpdateDisplay()
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (itemsDisplayed.ContainsKey(inventory.Container[i]))
            {
                itemsDisplayed[inventory.Container[i]].GetComponentInChildren<TextMeshProUGUI>().text
                    = inventory.Container[i].amount.ToString("n0");
            }
            else
            {
                var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);

                obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                obj.GetComponentInChildren<TextMeshProUGUI>().text = inventory.Container[i].amount.ToString("n0");
                itemsDisplayed.Add(inventory.Container[i], obj);
            }
            //InventorySlot slot = inventory.Container.[i];

            //if (itemsDisplayed.ContainsKey(slot))
            //{
            //    itemsDisplayed[slot].GetComponentInChildren<TextMeshProUGUI>().text
            //        = slot.amount.ToString("n0");
            //}
            //else
            //{
            //    var obj = Instantiate(inventoryPrefab, Vector3.zero, Quaternion.identity, transform);
            //    obj.transform.GetChild(0).GetComponentInChildren<Image>().sprite =
            //      inventory.database.GetItem[slot.item.Id].uiDisplay;

            //    obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            //    obj.GetComponentInChildren<TextMeshProUGUI>().text = slot.amount.ToString("n0");
            //    itemsDisplayed.Add(slot, obj);
            //}

        }
    }
}
