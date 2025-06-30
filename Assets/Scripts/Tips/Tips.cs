using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tips : MonoBehaviour,IPointerClickHandler
{
    public void OnClicked()
    {
        SceneLoadManager.Instance.LoadScene();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClicked();
    }
    
}
