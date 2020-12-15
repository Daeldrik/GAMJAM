using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour

{
    [SerializeField]
    Vector3 StartPosition;
    [SerializeField]
    GameObject sol;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "sol") ;
        Vector3 CurrentPosition = StartPosition; 
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
