using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PictureList : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    private RectTransform rectTransform;
    private Vector2 pointerOffset;
    //拖动的左右边界
    

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 pointerPosition = new Vector2(eventData.position.x-rectTransform.position.x, rectTransform.position.y);
        pointerOffset = pointerPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 minPosition=new Vector2(-2000, rectTransform.position.y);
        Vector2 maxPosition=new Vector2(0,rectTransform.position.y);
        Vector2 newPosition = new Vector2(eventData.position.x-pointerOffset.x, rectTransform.position.y);
        newPosition.x = Mathf.Clamp(newPosition.x, minPosition.x, maxPosition.x);
        newPosition.y = Mathf.Clamp(newPosition.y, minPosition.y, maxPosition.y);
        rectTransform.position=newPosition;
   
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }
}
