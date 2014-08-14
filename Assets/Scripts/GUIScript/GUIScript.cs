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
        //Whole Cube Rotation
        if(GUI.Button(new Rect(60,30,30,30), "U"))
        {
            Receptor.BroadcastMessage("RubixVertical", true, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(60, 80, 30, 30), "D"))
        {
            Receptor.BroadcastMessage("RubixVertical", false, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(20, 50, 30, 30), "L"))
        {
            Receptor.BroadcastMessage("RubixHorizontal", false, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(100, 50, 30, 30), "R"))
        {
            Receptor.BroadcastMessage("RubixHorizontal", true, SendMessageOptions.DontRequireReceiver);
        }
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
            rotationParams[1] = false;
            Receptor.BroadcastMessage("RotateRight", rotationParams, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(200, Screen.height / 2 + 50, 30, 30), "!"))
        {
            rotationParams[0] = true;
            rotationParams[1] = false;
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
