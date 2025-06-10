using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarDrawSystem : MonoBehaviour
{
    string star;

    public TextMeshProUGUI[] StarTexts = new TextMeshProUGUI[5];


    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        string star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {
            star += new string('*', i) + "\n"; //별 생성 이후 줄 바꿈
        }

        StarTexts[0].text = star;
        Debug.Log(star);
    }

    public void Phase2()
    {
        string star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {       
            string spaces = new string(' ', 5 - i);// 공백 생성 (5-i 만큼)
            string stars = new string('*', i);   // 별 생성 (현재 i값 만큼) 
            star += spaces + stars + "\n";  // 한 줄 완성 이후에 줄바꿈 추가
        }
        StarTexts[1].text = star;
        Debug.Log(star);
    }

    public void Phase3()
    {
        string star = string.Empty;

        for (int i = 5; i >= 1; i--)
        {
            string stars = new string('*', i);  //별 생성 (현재 i값 만큼)
            star += stars + "\n"; // 이후 줄 바꿈
        }
        StarTexts[2].text = star;
        Debug.Log(star);
    }

    public void Phase4()
    {
        string star = string.Empty;

        for (int i = 5; i >= 1; i--)
        {
            string spaces = new string(' ', 5 - i); // 공백 생성 (5-i 만큼)
            string stars = new string('*', i); // 별 생성 (현재 i값 만큼) 
            star += spaces + stars + "\n"; // 한 줄 완성 이후에 줄바꿈 추가
        }
        StarTexts[3].text = star;
        Debug.Log(star);
    }

    public void Phase5()
    {
        string star = string.Empty;

       
        for (int i = 1; i <= 5; i++) // 상단 피라미드
        {
            string spaces = new string(' ', 5 - i);// 공백 생성 (5-i 만큼)
            string stars = new string('*', 2 * i - 1); //별을 2 * i - 1를 하여서 홀수로 만듬
            star += spaces + stars + "\n"; // 한 줄 완성 이후에 줄바꿈 추가
        }

     
        for (int i = 4; i >= 1; i--) //하단 역피라미드
        {           
            string spaces = new string(' ', 5 - i); // 공백 생성 (5-i 만큼)
            string stars = new string('*', 2 * i - 1); //별을 2 * i - 1를 하여서 홀수로 만듬
            star += spaces + stars + "\n"; //한 줄 완성 이후에 줄바꿈 추가
        }
        StarTexts[4].text = star;
        Debug.Log(star);
    }
    void Update()
    {
        
    }
}
