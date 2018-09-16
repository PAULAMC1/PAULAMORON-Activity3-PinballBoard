using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotate : MonoBehaviour {
public Transform rotationPivot;
public float translationSpeed;

public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
transform.RotateAround(rotationPivot.position, Vector3.up, translationSpeed* Time.deltaTime);
		}
}