using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpaceCraft : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = this.transform.position;
        if (position.z <= 5.5)
        {
            float temp = 0.02f;
            position.z += temp;
            this.transform.position = position;
        }
    }
}
