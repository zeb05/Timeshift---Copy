using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{

    public float camSpeed;
    private Rigidbody myRigidbody;
    public float lcode;

    // Use this for initialization
    void Start ()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {

        lcode = GetComponent<Mouse_lock>().lcode;

        if (lcode == 1)
        {
            if (Input.GetAxis("Mouse Y") < 0.0f)
            {
                transform.eulerAngles += new Vector3(-camSpeed * Input.GetAxis("Mouse Y"), 0, 0);
            }
            else
            {
                transform.eulerAngles += new Vector3(0, 0, 0);
            }


            if (Input.GetAxisRaw("Mouse Y") > 0.0f)
            {
                transform.eulerAngles += new Vector3(-camSpeed * Input.GetAxis("Mouse Y"), 0, 0);
            }

            else
            {
                transform.eulerAngles += new Vector3(0, 0, 0);
            }
        }
    }
}
