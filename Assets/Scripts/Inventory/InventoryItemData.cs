using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemData : ScriptableObject
{
    public PowerUpType Type;
    public string key;
    public string id;
    public string displayName;
    public Sprite icon;
    public GameObject prefab;

    public string GetDetails()
    {
        return "Nombre: " + displayName + ", ID: " + id;
    }
}
