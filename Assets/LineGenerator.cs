using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour {
    public GameObject StageLineTate;
    public GameObject StageLineYoko;

	// Use this for initialization
	void Start () {
        for (float i = 0; i <= 10; i++)
        {
            Instantiate(StageLineTate, new Vector3(i + 0.5f, 0, -9.5f), Quaternion.identity);
            Instantiate(StageLineTate, new Vector3(-i + 0.5f, 0, -9.5f), Quaternion.identity);
            GameObject a = Instantiate(StageLineYoko, new Vector3(-9.5f, 0, i + 0.5f),Quaternion.identity);
            GameObject b = Instantiate(StageLineYoko, new Vector3(-9.5f, 0, -i + 0.5f), Quaternion.identity);
            a.transform.Rotate(0, 90, 0);
            b.transform.Rotate(0, 90, 0);

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
