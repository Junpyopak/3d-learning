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
        float ScaleTime = 0.2f;
        float SlowTime = 3f;
        float SlowTimeConvertSlow = ScaleTime * SlowTime;
        // Shared.Scenemgr.ChangeScene(eSCENE.LOGIN);
        Shared.MainCamera.Shake(0);
        Shared.MainCamera.ZoomEndStage(0F, -1.5F, 2f, SlowTime - 1.5f, 1f, Vector3.zero);
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

