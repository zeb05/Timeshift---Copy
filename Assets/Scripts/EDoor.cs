﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EDoor : MonoBehaviour
{

    public int safe;
    public int interf;
    public int interray;
    public int doorpos;
    public float x1;
    public float y1;
    public float z1;
    public float x2;
    public float y2;
    public float z2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GameObject character = GameObject.Find("Character");
        interf = character.GetComponent<Player_Interaction2>().interf;
        safe = character.GetComponent<SafeCheck>().safe;
        GameObject Myray = GameObject.Find("Myray");
        interray = Myray.GetComponent<Rayint>().interray;
        if (safe == 0)
        {
            if (interf == 1)
            {
                if (interray == 6)
                {
                    if (doorpos == 1)
                    {
                        doorpos = 2;
                        transform.position = new Vector3(x1, y1, z1);
                    }

                    else
                    {
                        doorpos = 1;
                        transform.position = new Vector3(x2, y2, z2);
                    }
                }
            }
        }
    }
}