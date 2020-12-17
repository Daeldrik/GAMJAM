using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MvmtPlat : MonoBehaviour
{
    Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    Vector3 direction = new Vector3(0f, 0f, 1f);
    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;

        float speed = 2f;


        if (transform.position.z >= 7f)
        { direction = new Vector3(0f, 0f, -1f); }
        if (transform.position.z <= -2.5f)
        { direction = new Vector3(0f, 0f, 1f); }



        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;


        rigidbody.MovePosition(newPosition);
    }
}