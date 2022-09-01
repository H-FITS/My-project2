using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(510, 180, 120, 80), "开始"))
        {
            // Application.LoadLevel("SampleScene");
            SceneManager.LoadScene("SampleScene");
        }
    }
}
