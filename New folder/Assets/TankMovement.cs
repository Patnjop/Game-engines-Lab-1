using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical") / 2;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
	}
}
