using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_items : MonoBehaviour
{
    public int interf;
    public int interray;
    public int intkey;

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
            if (interray == 3)
            {
                intkey = 1;
            }
        }

        /*if (intkey == 1)
        {
            if (interf == 1)
            {
                if (interray == 4)
                {
                    intkey = 0;
                }
            }
        }*/
    }
}
