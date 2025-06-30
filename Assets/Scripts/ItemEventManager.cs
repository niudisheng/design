using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemEventManager : MonoBehaviour
{
    public static ItemOBJSO itemOBJSO;
    public TextMeshProUGUI Description;
    public Image ItemSprite;
    public int testID;
    private void Awake()
    {
        // MyEventManager.Instance.AddEventListener(unitEvent.ShowTips.ToString(), ShowItemTips);
    }

    private void ShowItemTips()
    {
        // var tip = Instantiate(itemOBJSO.TipPrefab, Values.canvas.transform);
    }

    private void Start()
    {
        InitScene();
    }

    [ContextMenu("Test")]
    public void Test()
    {
        Debug.Log("Test");
        itemOBJSO = Resources.Load<ItemOBJSO>($"Data/Item{testID}");
        Debug.Log(itemOBJSO.itemID);
        InitScene();
    }

    public void InitScene()
    {
        if (itemOBJSO == null)
        {
            Debug.LogWarning("ItemOBJSO is null");
            return;
        }

        ItemSprite.sprite = itemOBJSO.itemIcon;
        Description.text = itemOBJSO.Description;
        // InitTips();
    }

    private void InitTips()
    {
        // MyEventManager.Instance.EventTrigger(unitEvent.ShowTips.ToString());
    }
}