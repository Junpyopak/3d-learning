using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public partial class UI_TITLE : MonoBehaviour
{
    public JoyStick JOYSTICK;
    //상속을 쓰면 tag 안써도됌
    public class actor
    { }

    public class Character : actor
    { }

    public class Player : Character { }
    private void Start()
    {
        SetVideo();
    }
    public void onBtnTitle()
    {
        Shared.Scenemgr.ChangeScene(eSCENE.LOGIN);
    }

    public void OnPointerDown(BaseEventData eventData)
    {
        JOYSTICK.gameObject.SetActive(true);

#if UNITY_ANDROID
#if UNITY_EDITOR
            JOYSTICK.transform.position= Input.mousePosition;
#else
       Touch touch = Input.GetTouch(0);

        JOYSTICK.transform.position=touch.position;
#endif
#endif
        JOYSTICK.OnDown((PointerEventData)eventData);
    }

    public void OnPointerUp(BaseEventData eventData)
    {
        JOYSTICK.gameObject.SetActive(false);
        JOYSTICK.OnUp((PointerEventData)eventData);
    }
    public void OnDrag(BaseEventData eventData)
    {
        JOYSTICK.OnDrag((PointerEventData)eventData);
    }
}

