using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointGeneration : MonoBehaviour {

    public int WaypointCount;
    public List<GameObject> waypoints = new List<GameObject>();
    public float addedAngle;
    public int increments = 0;
    public float adjacentLength;
    public int radius = 5;
    float sphereX;
    float sphereZ;
	// Use this for initialization
	void Start () {
        
        addedAngle = Mathf.PI * 2 / WaypointCount;

        for (int i = 0; i < WaypointCount; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphereX = Mathf.Sin(addedAngle*increments) * radius;
            sphereZ = Mathf.Cos(addedAngle * increments) * radius;
            sphere.GetComponent<Collider>().enabled = false;
            sphere.transform.position = new Vector3(sphereX, 0.5f, sphereZ);
            increments++;
            waypoints.Add(sphere);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
