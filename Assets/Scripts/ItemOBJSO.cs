using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "ItemOBJSO", menuName = "Item/ItemOBJSO")]
public class ItemOBJSO : ScriptableObject
{
    public string itemName;
    public int itemID;
    [TextArea] public string Description;
    public Sprite itemIcon;
    public itemEvent itemEvent;
    // public GameObject TipPrefab;
}