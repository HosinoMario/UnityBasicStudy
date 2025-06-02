using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScripts : MonoBehaviour
{
    public float MoveSpeed;
    public float JumpPower;
    private Rigidbody2D rb;
    public float currentY;
    public Text PlayerYText;
    public GameObject GameOverText;
    bool isDeath;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isDeath = false;
    }

    // Update is called once per frame
    void Update()
    {

        currentY = transform.position.y;

        PlayerYText.text = "Player Y Pos:" + currentY.ToString("F1");

        if (isDeath == false)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector2(rb.velocity.x, 0); // 기존 Y속도 초기화 (필요 시)
                rb.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
            }
        }


        if (currentY <= -10)
        {
            isDeath = true;
            GameOverText.SetActive(true);
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        }



    }
}
