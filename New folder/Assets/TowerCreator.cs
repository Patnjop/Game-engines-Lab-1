using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCreator : MonoBehaviour
{

    float addedAngle;
    float cubeCount;
    bool even;
    public int circleRadius;
    public int heightCount;
    float cubeX;
    float cubeZ;
    float cubeCirc;
    float cubeHeight = 0.5f;
    float increments;
    public Collider coll;

    RaycastHit hit;
    // Use this for initialization

    void Start()
    {

        cubeCirc = Mathf.PI * 2f * circleRadius;
        coll = GetComponent<Collider>();
        cubeCount = cubeCirc / 1.5f;
        addedAngle = 2f * Mathf.PI / cubeCount;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            bool didhit = Physics.Raycast(ray, out hit, 500.0f);
            if (didhit)
            {
                BuildTower();
            }  

        }
    }

    void BuildTower()
    {
        for (int j = 0; j < heightCount; j++)
        {
            for (int i = 0; i < cubeCount; i++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cubeX = Mathf.Sin(addedAngle * increments) * circleRadius;
                cubeZ = Mathf.Cos(addedAngle * increments) * circleRadius;
                cube.transform.position = new Vector3(cubeX, cubeHeight, cubeZ);
                cube.transform.Rotate(0, (addedAngle * increments) * Mathf.Rad2Deg, 0);
                cube.GetComponent<Renderer>().material.color = Random.ColorHSV(0.4f, 0.8f, 0.8f, 1f, 0f, 1f);
                cube.AddComponent<Rigidbody>();
                increments++;
                even = !even;
            }
            if (even)
            {
                increments = 0.5f;
            }
            else
            {
                increments = 0;
            }
            cubeHeight += 1f;
        }
    }
}

