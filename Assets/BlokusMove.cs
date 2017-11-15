using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlokusMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W)){
            this.transform.Translate(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.transform.Translate(0, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Translate(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.Translate(1, 0, 0);
        }
	}
}
