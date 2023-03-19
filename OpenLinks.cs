using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class OpenLinks : MonoBehaviour
{
    public string url;

    void Update()
    {
        
    }
    public void OpenUrl()
    {
        #if !UNITY_EDITOR && UNITY_WEBGL
        OpenTab(url);
        #endif
        #if UNITY_EDITOR && !UNITY_WEBGL
        Debug.Log("Clicked");
        #endif

    }

    [DllImport("__Internal")]
    private static extern void OpenTab(string url);
}
