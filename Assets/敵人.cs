using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 敵人 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position += new Vector3(0, -0.05f, 0);
    }
}
