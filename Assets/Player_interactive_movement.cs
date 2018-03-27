using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_interactive_movement : MonoBehaviour {

    public int isafe;
    public int interf;
    public int Onum;
    public int interray;
    public float x;
    public float y;
    public float z;

    // Use this for initialization
    void Start () {
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
                    transform.position = new Vector3(x, y, z);
                }
            }
        }
    }
}
