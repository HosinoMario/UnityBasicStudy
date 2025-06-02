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

    private int jumpCount = 0;
    private int maxJumps = 2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (IsGrounded() && RB.velocity.y <= 0.01f)
        {
            jumpCount = 0;
        }



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);

        }


        if (Input.GetKey(KeyCode.DownArrow))
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
