using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] RectTransform stickTrans;
    [SerializeField] RectTransform backgroundTrans;
    [SerializeField] RectTransform centerTrans;

    public void OnDrag(PointerEventData eventData)
    {
         Vector2 touchPos = eventData.position;
         Vector2 centerPos = backgroundTrans.position;

         Vector2 localOffset = Vector2.ClampMagnitude(touchPos - centerPos, backgroundTrans.sizeDelta.x/2);
         stickTrans.position = localOffset + centerPos;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        backgroundTrans.position = eventData.position;
        stickTrans.position = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        backgroundTrans.position = centerTrans.position;
        stickTrans.position = backgroundTrans.position;
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
