using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static void LoadItem(int itemID)
    {
        ItemEventManager.itemOBJSO = Resources.Load<ItemOBJSO>($"Data/Item{itemID}");
        SceneLoadManager.LoadScene((int)Values.Scene.ItemScene);
    }

    public static void LoadMenu()
    {
        SceneLoadManager.LoadScene((int)Values.Scene.MainMenu);
    }
}
