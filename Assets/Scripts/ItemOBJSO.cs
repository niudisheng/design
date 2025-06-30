using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "ItemOBJSO", menuName = "Item/ItemOBJSO")]
public class ItemOBJSO : ScriptableObject
{
    [TextArea(3, 100)]
    public string itemName;
    public int itemID;
    [TextArea(10, 100)] public string Description;
    public Sprite itemIcon;
    public itemEvent itemEvent;
}