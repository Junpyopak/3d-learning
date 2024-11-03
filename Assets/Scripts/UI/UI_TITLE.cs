using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_TITLE : MonoBehaviour
{
   public void onBtnTitle()
    {
        Shared.Scenemgr.ChangeScene(eSCENE.LOGIN);
    }
}
