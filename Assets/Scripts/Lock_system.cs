﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock_system : MonoBehaviour
{

    public int interf;
    public int interray;
    public int intkey;
    public int intlocked1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GameObject character = GameObject.Find("Character");
        interf = character.GetComponent<Player_Interaction2>().interf;
        GameObject Myray = GameObject.Find("Myray");
        interray = Myray.GetComponent<Rayint>().interray;
        GameObject inven = GameObject.Find("Inventory");
        intkey = inven.GetComponent<Character_items>().intkey;

        if (intkey == 1)
        {
            if (interf == 1)
            {
                if (interray == 4)
                {
                    intlocked1 = 1;
                }
            }
        }
    }
}
