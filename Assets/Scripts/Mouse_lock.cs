using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_lock : MonoBehaviour
{
    CursorLockMode locked;
    public float lcode;

    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        if (lcode == 1)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        else if (lcode == 2)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        else if (lcode >= 3)
        {
            lcode = 1;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            lcode += 1;
        }
    }
}