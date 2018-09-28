using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColour : MonoBehaviour {

    public int newGreen;
    public int newRed;
    public int newBlue;
    private Material thisMaterial;

	// Use this for initialization
	void Start () {
        int newRed = UnityEngine.Random.Range(0, 255);
        int newGreen = UnityEngine.Random.Range(0, 255);
        int newBlue = UnityEngine.Random.Range(0, 255);
        Renderer thisRenderer = GetComponent<Renderer>();
        Material thisMaterial = thisRenderer.material;
	}

    // Update is called once per frame
    void Update () {

        thisMaterial.color = new Color(newRed, newGreen, newBlue, 1);

    }
}
