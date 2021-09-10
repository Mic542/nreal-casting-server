using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseApp : MonoBehaviour
{

    public void Close()
    {

#if !UNITY_EDITOR
        Application.Quit();
#endif

    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {

        }
    }
}
