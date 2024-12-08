using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TableReLoad : MonoBehaviour
{
    [MenuItem("CS_Util/Table/CSV &F1",false,1)]

    static public void ParserTableCsv()
    {
        Shared.TableMgr = new Table_Manager();
        Shared.TableMgr.Init();
        Shared.TableMgr.Save();
    }
}
