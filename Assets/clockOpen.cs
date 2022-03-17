using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockOpen : MonoBehaviour
{

    public GameObject aiguille1;
    public GameObject aiguille2;

    void Update()
    {
        Debug.Log(aiguille1.transform.rotation);
        if (-125/180 < aiguille1.transform.rotation.z && aiguille1.transform.rotation.z < -115/180)
        {
            if (-5/180 < aiguille2.transform.rotation.z && aiguille2.transform.rotation.z < 5/180)
            {
                //ouverture de la cloche
                Debug.Log("ouvert");
            }
        }
    }
}
