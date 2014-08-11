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

    void Start()
    {
        BuildMatrix();
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (GameObject cube in currRubix)
            {
                Debug.Log(cube.transform.position);
            }
        }
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
