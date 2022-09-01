using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dimian : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(510, 180, 120, 80), "退出"))
        {
            Application.Quit();
        }
        if (GUI.Button(new Rect(510, 300, 120, 80), "重新开始"))
        {
            // Application.LoadLevel("SampleScene");
            SceneManager.LoadScene("SampleScene");
        }
    }
}