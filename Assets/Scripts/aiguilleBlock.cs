using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiguilleBlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //bool action = this.gameObject.GetComponent<Valve.VR.InteractionSystem.Interactable>().attachEaseIn;
        //bool action = this.gameObject.transform.rotation.eulerAngles.y != 0;

        if (this.gameObject.transform.localRotation.eulerAngles.y >= 0.001)
        {
            this.gameObject.GetComponent<CapsuleCollider>().isTrigger = true;
        }
        else
        {
            this.gameObject.GetComponent<CapsuleCollider>().isTrigger = false;
        }
    }
}
