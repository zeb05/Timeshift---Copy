using UnityEngine;
using System.Collections;

public class Movement_script_test : MonoBehaviour
{

    public float moveSpeed;
    private Rigidbody myRigidbody;
    private bool playerMoving;
    public float turnSpeed;
    public float lcode;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

    }
    
    // Update is called once per frame
    void Update()
    {
        lcode = GetComponent<Mouse_lock>().lcode;
        playerMoving = false;
        
        if (lcode == 1)
        {
            if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5)
            {
                transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
                playerMoving = true;
            }

            if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5)
            {
                transform.Translate(new Vector3(0f, 0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime));
                playerMoving = true;
            }

            if (Input.GetAxis("Mouse X") > 0.0f)
            {
                transform.eulerAngles += new Vector3(0, turnSpeed * Input.GetAxis("Mouse X"), 0);
                playerMoving = true;
            }
            else
            {
                transform.eulerAngles += new Vector3(0, 0, 0);
                playerMoving = true;
            }


            if (Input.GetAxisRaw("Mouse X") < 0.0f)
            {
                transform.eulerAngles += new Vector3(0, turnSpeed * Input.GetAxis("Mouse X"), 0);
                playerMoving = true;
            }
            

            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.eulerAngles = new Vector3(0, 90, 0);
                transform.position = new Vector3(-9, 0, 0);
                playerMoving = false;
            }
           
        }

    }
}