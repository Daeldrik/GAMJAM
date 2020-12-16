using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorIsLava : MonoBehaviour
{
    Vector3 StartPosition;
    

    private void Start()
    {
        StartPosition = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Floor")
        { transform.position = StartPosition;}

    }
}
