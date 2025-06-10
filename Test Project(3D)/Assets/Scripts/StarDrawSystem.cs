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
            star += new string('*', i) + "\n"; //�� ���� ���� �� �ٲ�
        }

        StarTexts[0].text = star;
        Debug.Log(star);
    }

    public void Phase2()
    {
        string star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {       
            string spaces = new string(' ', 5 - i);// ���� ���� (5-i ��ŭ)
            string stars = new string('*', i);   // �� ���� (���� i�� ��ŭ) 
            star += spaces + stars + "\n";  // �� �� �ϼ� ���Ŀ� �ٹٲ� �߰�
        }
        StarTexts[1].text = star;
        Debug.Log(star);
    }

    public void Phase3()
    {
        string star = string.Empty;

        for (int i = 5; i >= 1; i--)
        {
            string stars = new string('*', i);  //�� ���� (���� i�� ��ŭ)
            star += stars + "\n"; // ���� �� �ٲ�
        }
        StarTexts[2].text = star;
        Debug.Log(star);
    }

    public void Phase4()
    {
        string star = string.Empty;

        for (int i = 5; i >= 1; i--)
        {
            string spaces = new string(' ', 5 - i); // ���� ���� (5-i ��ŭ)
            string stars = new string('*', i); // �� ���� (���� i�� ��ŭ) 
            star += spaces + stars + "\n"; // �� �� �ϼ� ���Ŀ� �ٹٲ� �߰�
        }
        StarTexts[3].text = star;
        Debug.Log(star);
    }

    public void Phase5()
    {
        string star = string.Empty;

       
        for (int i = 1; i <= 5; i++) // ��� �Ƕ�̵�
        {
            string spaces = new string(' ', 5 - i);// ���� ���� (5-i ��ŭ)
            string stars = new string('*', 2 * i - 1); //���� 2 * i - 1�� �Ͽ��� Ȧ���� ����
            star += spaces + stars + "\n"; // �� �� �ϼ� ���Ŀ� �ٹٲ� �߰�
        }

     
        for (int i = 4; i >= 1; i--) //�ϴ� ���Ƕ�̵�
        {           
            string spaces = new string(' ', 5 - i); // ���� ���� (5-i ��ŭ)
            string stars = new string('*', 2 * i - 1); //���� 2 * i - 1�� �Ͽ��� Ȧ���� ����
            star += spaces + stars + "\n"; //�� �� �ϼ� ���Ŀ� �ٹٲ� �߰�
        }
        StarTexts[4].text = star;
        Debug.Log(star);
    }
    void Update()
    {
        
    }
}
