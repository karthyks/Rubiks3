using UnityEngine;
using System.Collections;
using System;

public class ScriptHandler : MonoBehaviour {

    GameObject[, ,] startRubix;
    GameObject[, ,] currRubix;
    GameObject Pivot;
    public float cubeSize = 0.3048f;

    GameObject[] face;
    void Awake()
    {
        startRubix = new GameObject[3, 3, 3];
        currRubix = new GameObject[3, 3, 3];
        face = new GameObject[9];
    }

    void Start()
    {
        BuildMatrix();
        GameObject.FindGameObjectWithTag("Rubix").transform.DetachChildren();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ResetParent();
    }

    void RotateUp(bool[] rotationParam)
    {
        bool right = rotationParam[0];
        bool up = rotationParam[1];
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");       
        Pivot = new GameObject("Pivot");
        Pivot.transform.position = new Vector3(0,0,0);
        foreach (GameObject cube in cubes)
        {
            if (up)
            {
                if (cube.transform.position.y > 0)
                {
                    cube.transform.parent = Pivot.transform;
                }
            }
            else
            {
                if (cube.transform.position.y < 0)
                {
                    cube.transform.parent = Pivot.transform;
                }
            }
        }
        if (right)
        {
            Pivot.transform.RotateAround(Pivot.transform.position, Vector3.up, -90);
        }
        else
        {
            Pivot.transform.RotateAround(Pivot.transform.position, Vector3.up, 90);
        }

        int i = 0;
        foreach (Transform child in Pivot.transform)
        {
            face[i] = child.gameObject;
            i++;

        }
        Pivot.transform.DetachChildren();
        Destroy(Pivot);
        ResetParent();
    }

    void ResetParent()
    {
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");
        foreach (GameObject faceCube in face)
        {
            foreach (GameObject cube in cubes)
            {
                if (faceCube.name == cube.name)
                {
                    double x = Mathf.Floor(faceCube.transform.position.x * 100) / 100;
                    double y = Mathf.Floor(faceCube.transform.position.y * 100) / 100;
                    double z = Mathf.Floor(faceCube.transform.position.z * 100) / 100;
                    cube.transform.position = new Vector3((float)(Math.Round(x, 1)), (float)(Math.Round(y, 1)), (float)(Math.Round(z, 1)));
                }
            }
        }
    }

    void RotateRight(bool[] rotationParam)
    {
        bool up = rotationParam[0];
        bool right = rotationParam[1];
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");
        Pivot = new GameObject("Pivot");
        Pivot.transform.position = new Vector3(0, 0, 0);
        Pivot.transform.parent = GameObject.FindGameObjectWithTag("Rubix").transform;
        foreach (GameObject cube in cubes)
        {
            if (right)
            {
                if (cube.transform.position.x > 0.1)
                    cube.transform.parent = Pivot.transform;
            }
            else
            {
                if (cube.transform.position.x < -0.1)
                    cube.transform.parent = Pivot.transform;
            }
        }
        if (up)
            Pivot.transform.RotateAround(Pivot.transform.position, Vector3.left, -90);
        else
            Pivot.transform.RotateAround(Pivot.transform.position, Vector3.left, 90);

        int i = 0;
        foreach (Transform child in Pivot.transform)
        {
            //Debug.Log(child.name);
            face[i] = child.gameObject;
            //Debug.Log(face[i].transform.position);
            i++;

        }
        Pivot.transform.DetachChildren();
        Destroy(Pivot);
        ResetParent();
    }

    void Rotation(Vector3 axis, float angle)
    {

    }
    void BuildMatrix()
    {
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");

        foreach (GameObject cube in cubes)
        {
            //Front Facing Cubes
            if (cube.transform.position == new Vector3(-cubeSize, cubeSize, -cubeSize))
                currRubix[0, 0, 0] = cube;
            if (cube.transform.position == new Vector3(0, cubeSize, -cubeSize))
                currRubix[0, 1, 0] = cube;
            if (cube.transform.position == new Vector3(cubeSize, cubeSize, -cubeSize))
                currRubix[0, 2, 0] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, 0, -cubeSize))
                currRubix[1, 0, 0] = cube;
            if (cube.transform.position == new Vector3(0, 0, -cubeSize))
                currRubix[1, 1, 0] = cube;
            if (cube.transform.position == new Vector3(cubeSize, 0, -cubeSize))
                currRubix[1, 2, 0] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, -cubeSize, -cubeSize))
                currRubix[2, 0, 0] = cube;
            if (cube.transform.position == new Vector3(0, -cubeSize, -cubeSize))
                currRubix[2, 1, 0] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, -cubeSize, -cubeSize))
                currRubix[2, 2, 0] = cube;

            //Back Facing Cubes
            if (cube.transform.position == new Vector3(-cubeSize, cubeSize, cubeSize))
                currRubix[0, 0, 2] = cube;
            if (cube.transform.position == new Vector3(0, cubeSize, cubeSize))
                currRubix[0, 1, 2] = cube;
            if (cube.transform.position == new Vector3(cubeSize, cubeSize, cubeSize))
                currRubix[0, 2, 2] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, 0, cubeSize))
                currRubix[1, 0, 2] = cube;
            if (cube.transform.position == new Vector3(0, 0, cubeSize))
                currRubix[1, 1, 2] = cube;
            if (cube.transform.position == new Vector3(cubeSize, 0, cubeSize))
                currRubix[1, 2, 2] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, -cubeSize, cubeSize))
                currRubix[2, 0, 2] = cube;
            if (cube.transform.position == new Vector3(0, -cubeSize, cubeSize))
                currRubix[2, 1, 2] = cube;
            if (cube.transform.position == new Vector3(cubeSize, -cubeSize, cubeSize))
                currRubix[2, 2, 2] = cube;

            //Left Facing Cubes
            if (cube.transform.position == new Vector3(-cubeSize, cubeSize, -cubeSize))
                currRubix[0, 0, 0] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, cubeSize, 0))
                currRubix[0, 0, 1] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, cubeSize, cubeSize))
                currRubix[0, 0, 2] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, 0, -cubeSize))
                currRubix[1, 0, 0] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, 0, 0))
                currRubix[1, 0, 1] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, 0, cubeSize))
                currRubix[1, 0, 2] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, -cubeSize, -cubeSize))
                currRubix[2, 0, 0] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, -cubeSize, 0))
                currRubix[2, 0, 1] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, -cubeSize, cubeSize))
                currRubix[2, 0, 2] = cube;

            //Right Facing Cubes
            if (cube.transform.position == new Vector3(cubeSize, cubeSize, -cubeSize))
                currRubix[0, 2, 0] = cube;
            if (cube.transform.position == new Vector3(cubeSize, cubeSize, 0))
                currRubix[0, 2, 1] = cube;
            if (cube.transform.position == new Vector3(cubeSize, cubeSize, cubeSize))
                currRubix[0, 2, 2] = cube;
            if (cube.transform.position == new Vector3(cubeSize, 0, -cubeSize))
                currRubix[1, 2, 0] = cube;
            if (cube.transform.position == new Vector3(cubeSize, 0, 0))
                currRubix[1, 2, 1] = cube;
            if (cube.transform.position == new Vector3(cubeSize, 0, cubeSize))
                currRubix[1, 2, 2] = cube;
            if (cube.transform.position == new Vector3(cubeSize, -cubeSize, -cubeSize))
                currRubix[2, 2, 0] = cube;
            if (cube.transform.position == new Vector3(cubeSize, -cubeSize, 0))
                currRubix[2, 2, 1] = cube;
            if (cube.transform.position == new Vector3(cubeSize, -cubeSize, cubeSize))
                currRubix[2, 2, 2] = cube;

            //Up Facing Cubes
            if (cube.transform.position == new Vector3(-cubeSize, cubeSize, -cubeSize))
                currRubix[0, 0, 0] = cube;
            if (cube.transform.position == new Vector3(0, cubeSize, -cubeSize))
                currRubix[0, 1, 0] = cube;
            if (cube.transform.position == new Vector3(cubeSize, cubeSize, -cubeSize))
                currRubix[0, 2, 0] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, cubeSize, 0))
                currRubix[0, 0, 1] = cube;
            if (cube.transform.position == new Vector3(0, cubeSize, 0))
                currRubix[0, 1, 1] = cube;
            if (cube.transform.position == new Vector3(cubeSize, cubeSize, 0))
                currRubix[0, 2, 1] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, cubeSize, cubeSize))
                currRubix[0, 0, 2] = cube;
            if (cube.transform.position == new Vector3(0, cubeSize, cubeSize))
                currRubix[0, 1, 2] = cube;
            if (cube.transform.position == new Vector3(cubeSize, cubeSize, cubeSize))
                currRubix[0, 2, 2] = cube;

            //Down Facing Cubes
            if (cube.transform.position == new Vector3(-cubeSize, -cubeSize, -cubeSize))
                currRubix[2, 0, 0] = cube;
            if (cube.transform.position == new Vector3(0, -cubeSize, -cubeSize))
                currRubix[2, 1, 0] = cube;
            if (cube.transform.position == new Vector3(cubeSize, -cubeSize, -cubeSize))
                currRubix[2, 2, 0] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, -cubeSize, 0))
                currRubix[2, 0, 1] = cube;
            if (cube.transform.position == new Vector3(0, -cubeSize, 0))
                currRubix[2, 1, 1] = cube;
            if (cube.transform.position == new Vector3(cubeSize, -cubeSize, 0))
                currRubix[2, 2, 1] = cube;
            if (cube.transform.position == new Vector3(-cubeSize, -cubeSize, cubeSize))
                currRubix[2, 0, 2] = cube;
            if (cube.transform.position == new Vector3(0, -cubeSize, cubeSize))
                currRubix[2, 1, 2] = cube;
            if (cube.transform.position == new Vector3(cubeSize, -cubeSize, cubeSize))
                currRubix[2, 2, 2] = cube;

            //MiddleCube
            if (cube.transform.position == new Vector3(0, 0, 0))
                currRubix[1, 1, 1] = cube;
        }
             
    }
}
