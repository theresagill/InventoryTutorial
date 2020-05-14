using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Items/Spiritual")]
public class SpiritualObject : ItemObject
{
    public float affirmBonus;
    public float defenseBonus;
    public void Awake()
    {
        type = ItemType.Spiritual;
    }
}
