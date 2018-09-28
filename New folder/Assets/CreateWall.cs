using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for (int r = 0; r < 7; r++)
        {
            for (int c = 0; c < 8; c++)
            {
                GameObject block = GameObject.CreatePrimitive(PrimitiveType.Cube);
                block.transform.position = new Vector3(r, c * 1.1f, 0);

                block.AddComponent<Rigidbody>();
                block.GetComponent<Renderer>().material.color = Random.ColorHSV(0, 1, 0, 1, 0, 1, 0, 1);
            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
