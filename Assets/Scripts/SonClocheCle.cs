using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonClocheCle : MonoBehaviour
{
    private AudioSource son_key;
    public GameObject key;
    private bool Horloge_est_reglee;
    public GameObject clock;
    public GameObject Cloche;
    public GameObject ClocheUnlock;


    void Start()
    {
        //instanciate();
        Horloge_est_reglee = false;
        son_key = gameObject.GetComponent<AudioSource>();
        //instanciated_key = gameObject.transform.GetChild(0).gameObject;

    }

    void Update()
    {
        if (clock.GetComponent<clockOpen>().opening)
        {
            ClocheUnlock.SetActive(true);
            Cloche.GetComponent<MeshFilter>().mesh = null;
            Horloge_est_reglee = true;
        }
        if (Horloge_est_reglee)
        {
            key.SetActive(true);
            son_key.Play();
            Horloge_est_reglee = false;
            //instanciated_key.transform.SetParent(null);
        }

    }

    //public void instanciate()
    //{
    //    instanciated_key1 = Instantiate(key);
    //    instanciated_key1.transform.SetParent(transform);
    //    instanciated_key1.transform.position = transform.position ;
    //    instanciated_key1.SetActive(false);
    //}

    ////après bien régler l'horloge on fait activer la cle
    //public void activate()
    //{
    //    instanciated_key1.SetActive(true);
    //}

}
