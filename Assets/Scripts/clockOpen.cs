using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockOpen : MonoBehaviour
{

    public GameObject aiguille1;
    public GameObject aiguille2;
    public bool opening = false;

    void Update()
    {
        if (230 < aiguille1.transform.rotation.eulerAngles.z && aiguille1.transform.rotation.eulerAngles.z < 250)
        {
            if (350 < aiguille2.transform.rotation.eulerAngles.z || aiguille2.transform.rotation.eulerAngles.z < 10)
            {
                //ouverture de la cloche
                opening = true;
            }
        }
    }
}
