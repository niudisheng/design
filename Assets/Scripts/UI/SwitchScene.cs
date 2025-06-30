using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using static SceneLoadManager;
public class SwitchScene : MonoBehaviour,IPointerClickHandler
{
    public int index;

    public void OnPointerClick(PointerEventData eventData)
    {
        GameManager.LoadItem(index);
    }
}
