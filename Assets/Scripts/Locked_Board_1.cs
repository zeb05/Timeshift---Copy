using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locked_Board_1 : MonoBehaviour
{

    public int interf;
    public int interray;
    public int intkey;

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
                    transform.Translate(new Vector3(0f, 5.1f, 0f));
                }
            }
        }
    }
}