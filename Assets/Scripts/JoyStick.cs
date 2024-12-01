using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JoyStick : MonoBehaviour
{
    public Image IMGBALL;

    Vector3 input = Vector3.zero;
    Vector3 Position = Vector3.zero;

    public void OnDown(PointerEventData eventData)
    {
        IMGBALL.rectTransform.anchoredPosition = Vector3.zero;
    }

    public void OnUp(PointerEventData eventData)
    {
        input = Vector3.zero;
        IMGBALL.rectTransform.anchoredPosition = Vector3.zero;
    }
    public void OnDrag(PointerEventData eventData)
    {
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(IMGBALL.rectTransform,eventData.position,eventData.pressEventCamera,out Vector2 localPoint))
        {
            localPoint.x = localPoint.x / IMGBALL.rectTransform.sizeDelta.x;
            localPoint.y = localPoint.y / IMGBALL.rectTransform.sizeDelta.y;

            input.x = localPoint.x;
            input.y = localPoint.y;

            input -= (input.magnitude > 1.0f) ? input.normalized : input;
            Position.x = input.x * IMGBALL.rectTransform.sizeDelta.x / 2f;
            Position.y = input.y * IMGBALL.rectTransform.sizeDelta.y / 2f;

            IMGBALL.rectTransform.anchoredPosition = Position;
            //�̵�
        }
    }
}
