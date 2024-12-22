using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Server : MonoBehaviour
{
    string Http = "http://58.78.211.182:3000/";

    string ConnectUrl = "process/dbconnect";
    string DisConnectUrl = "process/dbdisconnect";
    string UserSelectUrl = "process/userselect";

    IEnumerator DBPost(string Url,string Num)
    {
        WWWForm form = new WWWForm();
        form.AddField("num", Num);

        UnityWebRequest www = UnityWebRequest.Post(Url, form);
        
        yield return www.SendWebRequest();

        Debug.Log(www.downloadHandler.text);

        JSONNode node = JSONNode.Parse(www.downloadHandler.text);

        for(int i =0;i<node.Count; ++i)
        {
            //node[i].Value = node[i].Value.ToString();
            //Debug.Log($"{node[i].Value}");
        }
    }

    public void OnBtnConnect()
    {
        StartCoroutine(DBPost(Http + ConnectUrl,"dev"));
    }
}
