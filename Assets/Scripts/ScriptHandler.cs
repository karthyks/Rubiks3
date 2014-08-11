using UnityEngine;
using System.Collections;

public class ScriptHandler : MonoBehaviour {

    GameObject[, ,] startRubix;
    GameObject[, ,] currRubix;

    public float cubeSize = 0.3048f;
    void Awake()
    {
        startRubix = new GameObject[3, 3, 3];
        currRubix = new GameObject[3, 3, 3];
    }

    void BuildMatrix()
    {

    }
}
