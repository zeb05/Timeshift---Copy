using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_interaction_4 : MonoBehaviour
{

    public int interf;
    public int interray;
    public int doorpos;
    public int intlocked1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GameObject padlock = GameObject.Find("Lock_storage");
        intlocked1 = padlock.GetComponent<Lock_system>().intlocked1;
        GameObject character = GameObject.Find("Character");
        interf = character.GetComponent<Player_Interaction2>().interf;
        GameObject Myray = GameObject.Find("Myray");
        interray = Myray.GetComponent<Rayint>().interray;

        if (intlocked1 == 1)
        {
            if (interf == 1)
            {
                if (interray == 5)
                {
                    if (doorpos == 1)
                    {
                        doorpos = 2;
                        transform.eulerAngles -= new Vector3(0, 90, 0);
                    }
                    else
                    {
                        doorpos = 1;
                        transform.eulerAngles += new Vector3(0, 90, 0);
                    }
                }
            }
        }
    }
}
