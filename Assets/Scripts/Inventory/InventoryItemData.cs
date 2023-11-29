using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventory Item Data")]
public class InventoryItemData : ScriptableObject
{
    public string key;
    public string value;
    public string displayName;
    public Sprite icon;
    public GameObject prefab;
}