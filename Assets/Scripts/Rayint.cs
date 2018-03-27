using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayint : MonoBehaviour
{

    public int interray;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void
    OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "IntO1")
        {
            interray = 1;
        }
        if (other.gameObject.name == "Board")
        {
            interray = 2;
        }
        if (other.gameObject.name == "Key1")
        {
            interray = 3;
        }
        if (other.gameObject.name == "Lock1")
        {
            interray = 4;
        }
        if (other.gameObject.name == "Lboard")
        {
            interray = 5;
        }
        if (other.gameObject.name == "Elevator")
        {
            interray = 6;
        }
        if (other.gameObject.name == "Upbutton")
        {
            interray = 7;
        }
        if (other.gameObject.name == "Downbutton")
        {
            interray = 8;
        }
        /*
        if (other.gameObject.name == "")
        {
            interray = 1;
        }
        */
    }

    void
    OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "IntO1")
        {
            interray = 0;
        }
        if (other.gameObject.name == "Board")
        {
            interray = 0;
        }
        if (other.gameObject.name == "Key1")
        {
            interray = 0;
        }
        if (other.gameObject.name == "Lock1")
        {
            interray = 0;
        }
        if (other.gameObject.name == "LBoard")
        {
            interray = 0;
        }
        if (other.gameObject.name == "Elevator")
        {
            interray = 0;
        }
        if (other.gameObject.name == "Upbutton")
        {
            interray = 0;
        }
        if (other.gameObject.name == "Downbutton")
        {
            interray = 0;
        }
        /*
        if (other.gameObject.name == "")
        {
            interray = 0;
        }
        */
    }
}
