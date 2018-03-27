using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Count : MonoBehaviour
{

    private int frameCounter;
    private float timeCounter;
    public float lastFramerate;
    public float refreshTime = 0.1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeCounter < refreshTime)
        {
            timeCounter += Time.deltaTime;
            frameCounter++;
        }
        else
        {
            //This code will break if you set your refreshTime to 0, which makes no sense.
            lastFramerate = (float)frameCounter / timeCounter;
            frameCounter = 0;
            timeCounter = 0.0f;
        }
    }
}