using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static void LoadItem(int itemID)
    {
        ItemEventManager.itemOBJSO = Resources.Load<ItemOBJSO>($"Data/Item{itemID}");
        SceneLoadManager.LoadScene(1);
    }
}
