using UnityEngine;
using System.Collections;

public class RotationScript : MonoBehaviour {


    GameObject[] cubes;
    GameObject Pivot;
    float startAngles = 0.0f;

    float timer = 0.0f;
    void Start()
    {
        cubes = GameObject.FindGameObjectsWithTag("Cube");
        Pivot = new GameObject("Pivot");
        Pivot.transform.position = new Vector3(0, 0, 0);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            timer = 9.0f;
        }
        timer -= Time.deltaTime;
        if (timer > 0)
        {
            Rotate(Mathf.Round(timer));
        }
    }

    void Rotate(float value)
    {
        foreach (GameObject cube in cubes)
        {
            cube.transform.parent = Pivot.transform;
        }
        Pivot.transform.RotateAround(Pivot.transform.position, Vector3.up, value);
        //if (startAngle(Pivot.transform.rotation.eulerAngles.y) <= endAngles(startAngles))
        //{
        //    Pivot.transform.RotateAround(Pivot.transform.position, Vector3.up, Mathf.Round(45 * Time.deltaTime));
        //}
    }

    float startAngle(float value)
    {
        return Mathf.Round(value);
    }

    float endAngles(float value)
    {
        float start = value + 90;
        if (start > 359)
        {
            startAngles = startAngles % 360;
        }
        return Mathf.Round(start);
    }
    void StartRotate(bool start)
    {
        if (start)
        {
            startAngles = Pivot.transform.rotation.eulerAngles.y;
            start = false;
        }
    }
}
