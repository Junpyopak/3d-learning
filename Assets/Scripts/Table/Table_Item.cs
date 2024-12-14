using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table_Item : Table_Base
{
    [Serializable]
    public class Info
    {
        public int id;
        public byte Type;
        public int Name;
        public int Dec;
    }
    public Dictionary<int, Info> Dictionary = new Dictionary<int, Info>();

    public Info Get(int _Id)
    {
        if (Dictionary.ContainsKey(_Id))
            return Dictionary[_Id];

        return null;
    }
    public void Init_Binary(string _Name)
    {
        Load_Binary<Dictionary<int, Info>>(_Name, ref Dictionary);
    }
    public void Save_Binary(string _Name)
    {
        Save_Binary(_Name, Dictionary);
    }

    public void Init_Csv(string _Name, int _StartRow, int _StartCol)
    {
        CSVReader reader = GetSVReader(_Name);
        for (int row = _StartRow; row < reader.row; ++row)
        {
            Info info = new Info();
            if (Read(reader, info, row, _StartCol) == false)
                break;

            Dictionary.Add(info.id, info);
        }
    }

    protected bool Read(CSVReader _Reader, Info _Info, int _Row, int _Col)
    {
        if (_Reader.reset_row(_Row, _Col) == false)
            return false;

        _Reader.get(_Row, ref _Info.id);
        _Reader.get(_Row, ref _Info.Type);
        _Reader.get(_Row, ref _Info.Name);
        _Reader.get(_Row, ref _Info.Dec);

        return true;
    }
}
