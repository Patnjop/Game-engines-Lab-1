using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WayPointGeneration : MonoBehaviour {

    public int WaypointCount;
    Transform AIPosition;
    public Transform playerTank;
    List<GameObject> waypoints = new List<GameObject>();
    float addedAngle;
    int increments = 0;
    public int radius = 5;
    int activeWaypoint = 0;
    int rotationWaypoint;
    float sphereX;
    float sphereZ;

    //UI
    public Text text;
    public Text text2;
    float angletoplayer;
    string playerinfront;

	// Use this for initialization
	void Start () {
        AIPosition = GetComponent<Transform>();
        addedAngle = Mathf.PI * 2 / WaypointCount;

        for (int i = 0; i < WaypointCount; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphereX = Mathf.Sin(addedAngle*increments) * radius;
            sphereZ = Mathf.Cos(addedAngle*increments) * radius;
            sphere.GetComponent<Collider>().enabled = false;
            sphere.transform.position = new Vector3 (sphereX, 0.5f, sphereZ);
            increments++;
            waypoints.Add(sphere);
        }
	}
	
	// Update is called once per frame
	void Update () {
        rotationWaypoint = activeWaypoint + 1;
        angletoplayer = Vector3.SignedAngle(AIPosition.position, playerTank.position, Vector3.up);
        transform.position = Vector3.MoveTowards(AIPosition.position, waypoints[activeWaypoint].transform.position, 0.05f);

        text.text = "Player is " + playerinfront;
        text2.text = "Angle to player is " + angletoplayer;

        if (Vector3.Distance(AIPosition.position, waypoints[activeWaypoint].transform.position) < 0.3f)
        {
            if (activeWaypoint +1 < waypoints.Count)
            {
                activeWaypoint++;
            }
            else if (activeWaypoint +1 == waypoints.Count)
            {
                activeWaypoint = 0;
            }
            transform.LookAt(waypoints[activeWaypoint].transform.position);
        }
        if (angletoplayer <= 0)
        {
            playerinfront = "behind";
        }
        else if(angletoplayer > 0)
        {
            playerinfront = "in front";
        }
    }
}
