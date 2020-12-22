using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetect : MonoBehaviour
{
    Vector3 checkpoint;
    // Start is called before the first frame update
    void Start()
    {
        checkpoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<100)
        {
            Debug.Log("You just died!");
            transform.position=checkpoint;
            
        }
    }
}
