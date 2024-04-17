using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using System;


#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuUiHandler : MonoBehaviour
{
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
       
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                Application.Quit(); // original code to quit Unity player
        #endif
    }

    public void ReadStringInput(string s)
    {   
        Debug.Log(s);
    //     MasterManager.Instance.userName = input;
    }
}
