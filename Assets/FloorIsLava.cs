using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorIsLava : MonoBehaviour
{
    Vector3 StartPosition;

    [SerializeField]
    Transform checkpointTransform;


    private void Start()
    {
        StartPosition = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Floor")
        { 
            
            
            transform.position = StartPosition;
        }

        if (collision.gameObject.tag == "Ground")
        { 
            
            transform.position = checkpointTransform.position; 
        }

    }
}
