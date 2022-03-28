using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class PhoneScript : MonoBehaviour
{
    enum Etat { Initial, Ringing, PickedUp, Listened };
    private Etat etat;


    public Transform player;

    private float delay = 3.5f;
    private AudioSource sound;
    private AudioClip matrixSound;
    private Interactable inter;
    private float distanceEarToPhone = 0.5f;


    public double bpm = 600;
    private double spb;
    private double nextTime;
    



    // Start is called before the first frame update
    void Start()
    {
        etat = Etat.Initial;

        sound = GetComponent<AudioSource>();
        inter = GetComponent<Interactable>();

        spb = 60 / bpm;
    }

    // Update is called once per frame
    void Update()
    {
        switch((float)etat)
        {
            case (float)Etat.Initial:
                break;
            case (float)Etat.Ringing:
                if(inter.attachedToHand) { PickUpThePhone(); }
                break;
            case (float)Etat.PickedUp:
                if ((transform.parent.position - player.position).magnitude < distanceEarToPhone) { ListeningThePhone(); }
                break;
            case (float)Etat.Listened:
                if (Time.realtimeSinceStartup >= nextTime) { IncreasingFog(); }
                break;
            default:
                break;
        }
    }

    public void PhoneCall()
    {
        sound.PlayDelayed(delay);
        sound.loop = true;
        etat = Etat.Ringing;
    }

    private void PickUpThePhone()
    {
        sound.Stop();
        etat = Etat.PickedUp;
    }

    private void ListeningThePhone()
    {
        // lancement animation
        RenderSettings.fogDensity = 0;
        RenderSettings.fogColor = Color.black;
        RenderSettings.fog = true;
        etat = Etat.Listened;
    }

    private void IncreasingFog()
    {
        UnityEngine.Debug.Log("IncreasingFog");
        UnityEngine.Debug.Log(RenderSettings.fogDensity);

        if (RenderSettings.fogDensity != 1.0f)
        {
            RenderSettings.fogDensity += 0.02f;
            nextTime = Time.realtimeSinceStartup + spb;
        }
        else
        {
            Application.Quit();
        }
    }
}
