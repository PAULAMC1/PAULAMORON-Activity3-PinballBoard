using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("one shot");
		}

    // Update is called once per frame
	void Update () {
        print(Time.time);


        this.transform.position = new Vector3(13.6f, Mathf.Sin(Time.time)* 13 + 5, Mathf.Sin(Time.time)* 13
 - 15);
		
	}
}
