using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

    void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width/2 - 50, 30, 30,30), "<-"))
        {

        }
        if (GUI.Button(new Rect(Screen.width / 2 + 50, 30, 30, 30), "->"))
        {

        }
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height - 60, 30, 30), "<-"))
        {

        }
        if (GUI.Button(new Rect(Screen.width / 2 + 50, Screen.height - 60, 30, 30), "->"))
        {

        }
    }
}
