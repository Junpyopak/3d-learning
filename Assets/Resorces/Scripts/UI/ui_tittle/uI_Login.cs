using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class uI_Login : MonoBehaviour
{
    [SerializeField] Text textInput;
    // Start is called before the first frame update
    void Start()
    {
        //여기서 데이터 불러와서 계정이 있으면 로딩창(로비창)으로
        Shared.Scenemgr.GetPlayerPrefsStringKey("id");

        Debug.Log(PlayerPrefs.GetString("id"));

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnBtnLogin()
    {
        Shared.Scenemgr.SetPlayerPrefsStringKey("id", textInput.text);
        //if (Shared.Scenemgr.GetPlayerPrefsStringKey("id") == textInput.text)
        //{
        //    //Debug.Log(PlayerPrefs.GetString("id"));
        //    //
        //}
    }
}
