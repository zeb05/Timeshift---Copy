using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Interaction2 : MonoBehaviour
{

    public int interf;
    public int intkey;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            interf = 1;
        }
        else if (interf == 1)
        {
            interf = 0;
        }
    }
}
