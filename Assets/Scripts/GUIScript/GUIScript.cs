using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {
    GameObject Receptor;
    bool[] rotationParams;
    void Start()
    {
        rotationParams = new bool[2];
        Receptor = GameObject.Find("ScriptHandler");
    }
    void OnGUI()
    {
        // Up and Down

        if(GUI.Button(new Rect(Screen.width/2 - 50, 30, 30,30), "<"))
        {
            rotationParams[0] = false;
            rotationParams[1] = true;
            Receptor.BroadcastMessage("RotateUp", rotationParams, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(Screen.width / 2 + 50, 30, 30, 30), ">"))
        {
            rotationParams[0] = true;
            rotationParams[1] = true;
            Receptor.BroadcastMessage("RotateUp", rotationParams, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height - 60, 30, 30), "<"))
        {
            rotationParams[0] = false;
            rotationParams[1] = false;
            Receptor.BroadcastMessage("RotateUp", rotationParams, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(Screen.width / 2 + 50, Screen.height - 60, 30, 30), ">"))
        {
            rotationParams[0] = true;
            rotationParams[1] = false;
            Receptor.BroadcastMessage("RotateUp", rotationParams, SendMessageOptions.DontRequireReceiver);
        }

        // Left and Right
        if (GUI.Button(new Rect(200, Screen.height/2 -50, 30, 30), "i"))
        {
            rotationParams[0] = false;
            rotationParams[1] = true;
            Receptor.BroadcastMessage("RotateRight", rotationParams, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(200, Screen.height / 2 + 50, 30, 30), "!"))
        {
            rotationParams[0] = true;
            rotationParams[1] = true;
            Receptor.BroadcastMessage("RotateRight", rotationParams, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(Screen.width - 200, Screen.height / 2 - 50, 30, 30), "i"))
        {
            rotationParams[0] = false;
            rotationParams[1] = true;
            Receptor.BroadcastMessage("RotateRight", rotationParams, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(Screen.width - 200, Screen.height / 2 + 50, 30, 30), "!"))
        {
            rotationParams[0] = true;
            rotationParams[1] = true;
            Receptor.BroadcastMessage("RotateRight", rotationParams, SendMessageOptions.DontRequireReceiver);
        }
    }
}
