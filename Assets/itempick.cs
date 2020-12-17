using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class itempick : MonoBehaviour
{
    [SerializeField]
    int nombreObjetsObjectif;

    int nombreObjetsRamasses;

    [SerializeField]
    Transform checkpointTransform;

    private void Start()
    {
        //PositionDepart = transform.position;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Item")
        {
            nombreObjetsRamasses += 1;
            if(nombreObjetsRamasses == nombreObjetsObjectif)
            {
                //On a ramassé tous les objets qu'on voulait
                transform.position = checkpointTransform.position;
            }
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Item2")


        { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); ; }

    }
}

