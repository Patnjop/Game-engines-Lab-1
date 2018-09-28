using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public GameObject BulletPrefab;
    public Transform BulletTransform;
    public float speed = 2;
    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clone = Instantiate(BulletPrefab, BulletTransform.position, BulletTransform.rotation);
            clone.AddComponent<Rigidbody>().AddForce(Vector3.forward * 1000f);
        }
	}
}
