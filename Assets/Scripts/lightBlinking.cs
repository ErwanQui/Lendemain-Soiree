using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightBlinking : MonoBehaviour
{

    protected float timeRateRed = 1;
    protected float timeRateYellow = 2;
    protected float timeRateBlue = 3;
    protected float timeRateGreen = 4;

    protected int counterRed;
    protected int counterYellow;
    protected int counterGreen;
    protected int counterBlue;

    protected float timeRate = 3;
    protected int counter;

    void Awake()
    {
        gameObject.transform.Find("RedLed").GetComponent<Light>().enabled =false;
        gameObject.transform.Find("YellowLed").GetComponent<Light>().enabled = false;
        gameObject.transform.Find("BlueLed").GetComponent<Light>().enabled =false;
        gameObject.transform.Find("GreenLed").GetComponent<Light>().enabled =false;


        counterRed = 0;
        counterYellow = 0;
        counterBlue = 0;
        counterGreen = 0;
        counter = 0;
    }



    // Update is called once per frame
    void Update()
    {
        //timeRate = 3
        if ((Time.realtimeSinceStartup - counter * timeRate * 2) >= timeRate * 2)
        {
            counter += 1;
        }

        //lightBlinking the red led with timeRateRed
        if (1<=(Time.realtimeSinceStartup - counter * timeRate * 2) && (Time.realtimeSinceStartup - counter * timeRate * 2)<=5)
        {
            gameObject.transform.Find("RedLed").GetComponent<Light>().enabled = true;
        }
        else if ((Time.realtimeSinceStartup - counter * timeRate * 2) > 5 || (Time.realtimeSinceStartup - counter * timeRate * 2) < 1 )
        {
            gameObject.transform.Find("RedLed").GetComponent<Light>().enabled = false;
        }

        //lightBlinking the yellow led with timeRateYellow
        if (2 <= (Time.realtimeSinceStartup - counter * timeRate * 2) && (Time.realtimeSinceStartup - counter * timeRate * 2) <= 5)
        {
            gameObject.transform.Find("YellowLed").GetComponent<Light>().enabled = true;
        }
        else if ((Time.realtimeSinceStartup - counter * timeRate * 2) > 5 || (Time.realtimeSinceStartup - counter * timeRate * 2) < 2)
        {
            gameObject.transform.Find("YellowLed").GetComponent<Light>().enabled = false;
        }

        //lightBlinking the blue led with timeRateBlue
        if (3 <= (Time.realtimeSinceStartup - counter * timeRate * 2) && (Time.realtimeSinceStartup - counter * timeRate * 2) <= 5)
        {
            gameObject.transform.Find("BlueLed").GetComponent<Light>().enabled = true;
        }
        else if ((Time.realtimeSinceStartup - counter * timeRate * 2) > 5 || (Time.realtimeSinceStartup - counter * timeRate * 2) < 3)
        {
            gameObject.transform.Find("BlueLed").GetComponent<Light>().enabled = false;
        }

        //lightBlinking the green led with timeRateGreen
        if (4 <= (Time.realtimeSinceStartup - counter * timeRate * 2) && (Time.realtimeSinceStartup - counter * timeRate * 2) <= 5)
        {
            gameObject.transform.Find("GreenLed").GetComponent<Light>().enabled = true;
        }
        else if ((Time.realtimeSinceStartup - counter * timeRate * 2) > 5 || (Time.realtimeSinceStartup - counter * timeRate * 2) < 4)
        { 
            gameObject.transform.Find("GreenLed").GetComponent<Light>().enabled = false;
        }

       /* //lightBlinking the red led with timeRateRed
        if ((Time.realtimeSinceStartup - counterRed * timeRateRed * 2) >= timeRateRed*2)
        {
            counterRed += 1;
        }
        if ((Time.realtimeSinceStartup - counterRed * timeRateRed * 2) < timeRateRed)
        {
            gameObject.transform.Find("RedLed").GetComponent<Light>().enabled = true;
        }
        else if ((Time.realtimeSinceStartup - counterRed * timeRateRed * 2)>= timeRateRed || (Time.realtimeSinceStartup - counterRed * timeRateRed * 2) < timeRateRed*2)
        {
            gameObject.transform.Find("RedLed").GetComponent<Light>().enabled = false;
        }


        //lightBlinking the yellow led with timeRateYellow
        if ((Time.realtimeSinceStartup - counterYellow * timeRateYellow * 2)>= timeRateYellow*2)
        {
            counterYellow += 1;
        }
        if ((Time.realtimeSinceStartup - counterYellow * timeRateYellow * 2) < timeRateYellow)
        {
            gameObject.transform.Find("YellowLed").GetComponent<Light>().enabled = true;
        }
        else if ((Time.realtimeSinceStartup - counterYellow * timeRateYellow * 2) >= timeRateYellow || (Time.realtimeSinceStartup - counterYellow * timeRateYellow * 2) < timeRateYellow*2)
        {
            gameObject.transform.Find("YellowLed").GetComponent<Light>().enabled = false;
        }


        //lightBlinking the blue led with timeRateBlue
        if ((Time.realtimeSinceStartup - counterBlue * timeRateBlue * 2) >= timeRateBlue*2)
        {
            Debug.LogWarning("Je suis dans le BLUE");
            counterBlue += 1;
        }
        if ((Time.realtimeSinceStartup - counterBlue * timeRateBlue * 2) < timeRateBlue)
        {
            gameObject.transform.Find("BlueLed").GetComponent<Light>().enabled = true;
        }
        else if ((Time.realtimeSinceStartup - counterBlue * timeRateBlue * 2) >= timeRateBlue || (Time.realtimeSinceStartup - counterBlue * timeRateBlue * 2) < timeRateBlue*2)
        {
            gameObject.transform.Find("BlueLed").GetComponent<Light>().enabled = false;
        }


        //lightBlinking the green led with timeRateGreen
        if ((Time.realtimeSinceStartup - counterGreen * timeRateGreen * 2) >= timeRateGreen*2)
        {
            Debug.LogWarning("Je suis dans le GREEN");
            counterGreen += 1;
        }
        if ((Time.realtimeSinceStartup - counterGreen * timeRateGreen * 2) < timeRateGreen)
        {
            gameObject.transform.Find("GreenLed").GetComponent<Light>().enabled = true;
        }
        else if ((Time.realtimeSinceStartup - counterGreen * timeRateGreen * 2) >= timeRateGreen || (Time.realtimeSinceStartup - counterGreen * timeRateGreen * 2) < timeRateGreen*2)
        {
            gameObject.transform.Find("GreenLed").GetComponent<Light>().enabled = false;
        }*/
    }

}
