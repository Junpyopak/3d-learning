using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class UI_TITLE : MonoBehaviour
{
    
    //����� ���� tag �Ƚᵵ��
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
}
