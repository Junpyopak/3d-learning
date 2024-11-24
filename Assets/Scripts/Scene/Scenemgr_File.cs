using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public partial class Scenemgr : MonoBehaviour
{

    string FilePath = "Test.txt";

    public void SaveFile()
    {
        if (File.Exists(Application.dataPath + FilePath))
        {
            StreamWriter sw = File.CreateText(FilePath);

            sw.WriteLine("Test");

            sw.Close();
        }
        else
        {
            StreamReader sr = File.OpenText(Application.dataPath + FilePath);

            string sr1 = sr.ReadLine();

            sr.Close();
        }
    }
}
