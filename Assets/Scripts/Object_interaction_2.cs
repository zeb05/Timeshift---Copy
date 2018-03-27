using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_interaction_2 : MonoBehaviour
{

    public int isafe;
    public int interf;
    public int Onum;
    public int interray;
    public int doorpos;
    public float x1;
    public float y1;
    public float z1;
    public float rx1;
    public float ry1;
    public float rz1;
    public float x2;
    public float y2;
    public float z2;
    public float rx2;
    public float ry2;
    public float rz2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GameObject character = GameObject.Find("Character");
        interf = character.GetComponent<Player_Interaction2>().interf;
        isafe = character.GetComponent<SafeCheck>().isafe;
        GameObject Myray = GameObject.Find("Myray");
        interray = Myray.GetComponent<Rayint>().interray;
        if (isafe == 0)
        {
            if (interf == 1)
            {
                if (interray == Onum)
                {
                    if (doorpos == 1)
                    {
                        doorpos = 0;
                        transform.position = new Vector3(x1, y1, z1);
                        transform.eulerAngles = new Vector3(rx1, ry1, rz1);
                    }

                    else
                    {
                        doorpos = 1;
                        transform.position = new Vector3(x2, y2, z2);
                        transform.eulerAngles = new Vector3(rx2, ry2, rz2);
                    }
                }
            }
        }
    }
}
