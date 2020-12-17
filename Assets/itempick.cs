using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class itempick : MonoBehaviour
{
    [SerializeField]
    int nombreObjetsObjectif;
    [SerializeField]
    TMP_Text TextObject;
    int nombreObjetsRamasses;

    [SerializeField]
    Transform checkpointTransform;

    private void Start()
    {
        TextObject.text = "Mushrooms : " + nombreObjetsRamasses + " /21";
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Item")
        {
            nombreObjetsRamasses += 1;
            TextObject.text = "Mushrooms : " + nombreObjetsRamasses + " /21";
            if(nombreObjetsRamasses == nombreObjetsObjectif)
            {
                //On a ramassé tous les objets qu'on voulait
                transform.position = checkpointTransform.position;
            }
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Item2")


        { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  }

    }
}

