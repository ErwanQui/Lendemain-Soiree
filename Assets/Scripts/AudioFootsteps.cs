using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFootsteps : MonoBehaviour
{
    // 
    [Range(40.1f, 80.5f)]
    public double pasParMinutes = 60;
    private double minutesParPas;
    private double nextTime;
    public AudioClip sound;
    public GameObject player;

    [Range(0f, 1f)]
    public float volume;

    [Range(0.1f, 2.5f)]
    public float pitch;


    private AudioSource source;
    private float speed;

    

    void Awake()
    {
        gameObject.AddComponent<AudioSource>();
        source = GetComponent<AudioSource>();

        volume = 0.5f;
        pitch = 1f;
    }

    // Start is called before the first frame update
    void Start()
    {
        source.clip = sound;
        source.volume = volume;
        source.pitch = pitch;
        source.Play();

        minutesParPas = 60 / pasParMinutes;
    }

    // Update is called once per frame
    void Update()
    {
        Application.Quit();

        // S'il marche et qu'on a depasse nextTime
        if (true && Time.realtimeSinceStartup >= nextTime) playFootStep();


       /* source.volume = volume;
        source.pitch = pitch;
        source.loop = true;
        regulatesound();*/

    }

    public void regulatesound()
    {
        speed = player.gameObject.GetComponent<Rigidbody>().velocity.magnitude;
        source.volume = volume * speed;
        

    }

    private void playFootStep()
    {
        minutesParPas = 60 / pasParMinutes;

        source.Play();

        speed = player.gameObject.GetComponent<Rigidbody>().velocity.magnitude;

        //minutesParPas = minutesParPas;

        nextTime = Time.realtimeSinceStartup + minutesParPas;
    }
}
