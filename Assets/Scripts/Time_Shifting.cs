using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Shifting : MonoBehaviour
{

    public int safe;
    public int time;
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
        safe = character.GetComponent<SafeCheck>().safe;
        if (safe == 0)
        {
            if (time == 0)
            {
                transform.position = new Vector3(x1, y1, z1);
            }

            else if (time == 1)
            {
                transform.position = new Vector3(x2, y2, z2);
            }

            else if (time >= 2)
            {
                time = 0;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                time += 1;
            }
        }
    }
}
