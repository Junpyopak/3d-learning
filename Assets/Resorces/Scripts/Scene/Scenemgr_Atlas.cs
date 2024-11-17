using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public partial class Scenemgr : MonoBehaviour
{
    [NonReorderable]
    Dictionary<string,SpriteAtlas>DicSpriteAtlas = new Dictionary<string,SpriteAtlas>();


    public Sprite GetSpriteAtlas(string _Atlas, string _Name)
    {
        if(DicSpriteAtlas.ContainsKey(_Atlas))
            return DicSpriteAtlas[_Atlas].GetSprite(_Name);

        UnityEngine.Object obj = null;
        obj = Resources.Load("Atlas/"+_Atlas);

        if(obj == null)
        {
            Debug.Log("Load Fail" + _Atlas);
            return null;

        }

        SpriteAtlas sa = obj as SpriteAtlas;

        if (sa != null)
        {
            DicSpriteAtlas.Add(_Atlas, sa);
            return sa.GetSprite(_Name);
        }
        return null;
    }
}
