using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uI_Login : MonoBehaviour
{
    [SerializeField] Text textInput;
    // Start is called before the first frame update
    void Start()
    {
        //���⼭ ������ �ҷ��ͼ� ������ ������ �ε�â(�κ�â)����
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBtnLogin()
    {
        Shared.Scenemgr.SetPlayerPrefsStringKey("id", textInput.text);
        if(textInput.text.Length<0 == true)
        {
            Shared.Scenemgr.ChangeScene(eSCENE.TITLE);
        }
    }
}
