using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed;
    public float JumpPower;
    public Rigidbody RB;
    public LayerMask GroundLayer;
    public Transform GroundCheck;
    public float GroundCheckRadius = 0.2f;
    public Transform cameraPivot;
    public float MouseSensitivity = 3f;
    public float minLookAngle =  10f;
    public float maxLookAngle = 20f;
    private float verticalRotation = 0f;

    private int jumpCount = 0;
    private int maxJumps = 100;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity;

        transform.Rotate(Vector3.up * mouseX);

 
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, minLookAngle, maxLookAngle);

        cameraPivot.localEulerAngles = new Vector3(verticalRotation, 0f, 0f);



        if (IsGrounded() && RB.velocity.y <= 0.01f)
        {
            jumpCount = 0;
        }



        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);

        }


        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * MoveSpeed * Time.deltaTime);

        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < maxJumps)
            {
                RB.velocity = new Vector3(RB.velocity.x, 0f, RB.velocity.z);
                RB.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
                jumpCount++;
            }
        }


        bool IsGrounded()
        {
            return Physics.CheckSphere(GroundCheck.position, GroundCheckRadius, GroundLayer);
        }
    }
}
