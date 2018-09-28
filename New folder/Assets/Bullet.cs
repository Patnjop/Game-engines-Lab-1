using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public GameObject BulletPrefab;
    public Transform BulletTransformPosition;
    public Transform BulletTransformRotation;
    public float speed = 2;
    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clone = Instantiate(BulletPrefab, BulletTransformPosition.position, BulletTransformRotation.rotation);
            clone.AddComponent<Rigidbody>().AddForce(Vector3.forward * 1000f);
        }
	}
}
