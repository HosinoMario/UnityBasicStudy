using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Button : MonoBehaviour
{
    public IntroduceMyself Introduce;
    public bool Previous;
    public bool Next;
    private int PageNumber;
    public Text IntroduceText;
    //private bool hasTriggered = false;

    // Start is called before the first frame update
    void Start()
    {
        Introduce = GameObject.Find("Text Manager").GetComponent<IntroduceMyself>();
    }



    public void OnTriggerEnter(Collider other)
    {

     

        if (other.gameObject.tag == "Player")
        {
           
            if (Previous == true && Next == false)
            {
                Introduce.PageNumber -= 1;
                Debug.Log("이전 페이지!");
            }


            if (Previous == false && Next == true)
            {
                Introduce.PageNumber += 1;
                Debug.Log("다음 페이지!");
            }

        }

    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
