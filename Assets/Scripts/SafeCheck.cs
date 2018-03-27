using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeCheck : MonoBehaviour
{

    public int safe;
    public int isafe;

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
        if (other.gameObject.name == "NSZ")
        {
            safe = 1;
        }
        if (other.gameObject.name == "NIZ")
        {
            isafe = 1;
        }
        /*
        if (other.gameObject.name == "")
        {
            safe = 1;
        }
        */
    }

    void
    OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "NSZ")
        {
            safe = 0;
        }
        if (other.gameObject.name == "NIZ")
        {
            isafe = 0;
        }
        /*
        if (other.gameObject.name == "")
        {
            safe = 0;
        }
        */
    }
}
