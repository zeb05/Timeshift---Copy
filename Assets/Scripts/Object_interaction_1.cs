﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_interaction_1 : MonoBehaviour
{
    
    public int interf;
    public int interray;
    public int seed;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        GameObject character = GameObject.Find("Character");
        interf = character.GetComponent<Player_Interaction2>().interf;
        GameObject Myray = GameObject.Find("Myray");
        interray = Myray.GetComponent<Rayint>().interray;

        if (interf == 1)
        {
            if (interray == 1)
            {
                seed = 1;
            }
        }
        
    }
}