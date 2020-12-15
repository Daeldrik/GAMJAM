using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itempick : MonoBehaviour
{
 
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Item")

        { 
            transform.position = new Vector3 (0.59f, 0.96f, 1.86f);

            Destroy(GameObject.FindWithTag("Item"));
        }

    }
}

