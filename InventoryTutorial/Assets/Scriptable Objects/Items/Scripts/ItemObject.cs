﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Food,
    Equipment,
    Spiritual,
    Default
}

public enum Attributes
{
    Agility,
    Intellect,
    Stamina,
    Strength
}
 public abstract class ItemObject : ScriptableObject
 {
        public GameObject prefab;
        public ItemType type;
        [TextArea(15, 20)]
        public string description;

        //public ItemBuff[] buffs;
        //public int Id;
        //public Sprite uiDisplay;
 }
//public Item CreateItem()
// {
//        Item newItem = new Item(this);
//        return newItem;
// }

//Part 3 added Item as a class. 
[System.Serializable]
//public class Item
//{
//    public string Name;
//    public int Id;
//    public ItemBuff[] buffs;

    //Constructor
 //   public Item(ItemObject item)
 //   {
 //       Name = item.name;
 //       Id = item.Id;
 //       buffs = new ItemBuff[item.buffs.Length];
 //       for (int i = 0; i < buffs.Length; i++)
 //       {
 //           buffs[i] = new ItemBuff(item.buffs[i].min, item.buffs[i].max)
 //           {
 //               attribute = item.buffs[i].attribute
 //           };
 //       }
 //   }

//}//end of Item class
//[System.Serializable]
public class ItemBuff
{
    public Attributes attribute;
    public int value;
    public int min;
    public int max;
    public ItemBuff(int _min, int _max)
    {
        min = _min;
        max = _max;
        GenerateValue();
    }
    public void GenerateValue()
    {
        value = UnityEngine.Random.Range(min, max);
    }
}//end of ItemBuff class




