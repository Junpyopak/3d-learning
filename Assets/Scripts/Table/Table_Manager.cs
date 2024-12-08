using UnityEngine;
using UnityEngine.Playables;
using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class Table_Manager 
{

    public Table_Character Character = new Table_Character();

    public void Init()
    {
#if UNITY_EDITOR
        Character.Init_Csv("Character", 2, 0);
#else
        Character.Init_Binary("Character");
#endif
    }

    public void Save()
    {
        Character.Save_Binary("Character");

#if UNITY_EDITOR
        AssetDatabase.Refresh();
#endif
    }
}
