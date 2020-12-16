using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itempick : MonoBehaviour
{
    Vector3 PositionDepart;

    private void Start()
    {
        PositionDepart = transform.position;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Item")

        {
            transform.position = PositionDepart;

            Destroy(GameObject.FindWithTag("Item"));
        }

        if (collision.gameObject.tag == "Item2")

        {
            transform.position = PositionDepart;

            Destroy(GameObject.FindWithTag("Item2"));
        }

        if (collision.gameObject.tag == "Item3")

        {
            transform.position = PositionDepart;

            Destroy(GameObject.FindWithTag("Item3"));
        }

    }
}

