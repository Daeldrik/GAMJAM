using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorIsLava : MonoBehaviour
{
    public AudioClip LooseMusic;
    private AudioSource source;
    Vector3 StartPosition;

    [SerializeField]
    Transform checkpointTransform;


    private void Start()
    {
        source = GetComponent<AudioSource>();
        StartPosition = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Floor")
        {
            source.PlayOneShot(LooseMusic);
            
            transform.position = StartPosition;
        }

        if (collision.gameObject.tag == "Ground")
        {
            source.PlayOneShot(LooseMusic);
            
            transform.position = checkpointTransform.position; 
        }

    }
}
