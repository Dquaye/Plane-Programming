using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatepropellor : MonoBehaviour
{

    private float speed = 1000.0f;


   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate propellor
        transform.Rotate(0f,0f,speed * Time.fixedDeltaTime, Space.Self);
    }
}
