using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    // Use this for initialization
    float speed = 10.0f;
    void Update()
    {

        
            transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.World);
        
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(-Vector3.up * speed * Time.deltaTime);

    }

    // Update is called once per frame
   
}
