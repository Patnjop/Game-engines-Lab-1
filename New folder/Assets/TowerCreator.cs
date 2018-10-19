using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCreator : MonoBehaviour
{

    float addedAngle;
    float cubeCount;

    public int circleRadius;
    public int heightCount;
    float cubeX;
    float cubeZ;
    float cubeCirc;
    float cubeHeight = 0.5f;
    int increments;

    // Use this for initialization

    void Start()
    {

        cubeCirc = Mathf.PI * 2f * circleRadius;

        cubeCount = cubeCirc / 1.3f;
        addedAngle = 2f * Mathf.PI / cubeCount;

        //BuildTower();
        for (int j = 0; j < heightCount; j++)
        {
            for (int i = 0; i < cubeCount; i++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cubeX = Mathf.Sin(addedAngle * increments) * circleRadius;
                cubeZ = Mathf.Cos(addedAngle * increments) * circleRadius;
                cube.transform.position = new Vector3(cubeX, cubeHeight, cubeZ);
                cube.transform.rotation.SetAxisAngle(cube.transform.position, addedAngle);
                cube.AddComponent<Rigidbody>();
                increments++;
            }
            cubeHeight += 1f;
        }
    }

    void BuildTower()
    {
        Debug.Log(cubeCount);
    }
}

