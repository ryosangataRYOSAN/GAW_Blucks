using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour {

    int[,] pannels = new int[10,10];


	// Use this for initialization
	void Start () {
        for (int i = 0; i < pannels.GetLength(0); i++){
            for (int j = 0; j < pannels.GetLength(1); j++)
            {
                pannels[i,j] = 0;
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
