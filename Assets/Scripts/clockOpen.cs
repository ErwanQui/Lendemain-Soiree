using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockOpen : MonoBehaviour
{

    public GameObject aiguille1;
    public GameObject aiguille2;

    void Update()
    {
        //Debug.Log(aiguille1.transform.eulerAngles.z);
        if (230 < aiguille1.transform.rotation.eulerAngles.z && aiguille1.transform.rotation.eulerAngles.z < 250)
        {
            Debug.Log("ouverttt");

            if (350 < aiguille2.transform.rotation.eulerAngles.z || aiguille2.transform.rotation.eulerAngles.z < 10)
            {
                //ouverture de la cloche
                Debug.Log("ouvert");
            }
        }
    }
}
