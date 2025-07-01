using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static void LoadItem(int itemID)
    {
        Debug.Log("Loading Item");
        ItemEventManager.itemOBJSO = Resources.Load<ItemOBJSO>($"Data/Item{itemID}");
        if (Resources.Load<ItemOBJSO>($"Data/Item{itemID}") == null)
        {
            Debug.LogError($"Data/Item{itemID} not found");
            return;
        }
        SceneLoadManager.LoadScene((int)Values.Scene.ItemScene);
    }

    public static void LoadMenu()
    {
        SceneLoadManager.LoadScene((int)Values.Scene.MainMenu);
    }
}
