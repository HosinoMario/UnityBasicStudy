using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IntroduceMyself : MonoBehaviour
{
    private string MyName = "���ȭ"; // �̸�
    private string MyOfficalNickName = "����������";
    private int MyAge = 32; // ����
    private float MyHeight = 185.2f; // Ű

    private int MyBirthYear = 1993; //�¾ �⵵
    private int MyBirthMonth = 4; // �¾ ��
    private int MyBirthDate = 29; // �¾ ��

    private string MyMBTI = "INFP"; // MBTI
    private char MyBloodType = 'O'; // ������
    private int MySteamLevel = 88; // ���� ���� ����
    private int MySteamYears = 20; // ���� ������ Ȱ���� �⵵
    private int MySteamGameMount = 544; // ���� ���� ���� ��
    private string MyFavoriteDrink = "��� ���� ����"; //�����ϴ� ����Ʈ �帵ũ
    private string MyFavoriteHardDrink = "��׽�"; // �����ϴ� �ϵ� �帵ũ

    public TextMeshPro IntroduceText;
    public int PageNumber;


    // Start is called before the first frame update
    void Start()
    {
        PageNumber = 0;

        Introduce1();
        Introduce2();
        Introduce3();

        IntroduceA(MyName, MyAge, MyOfficalNickName);
        IntroduceB(MyBirthYear, MyBirthMonth, MyBirthDate, MyHeight, MyBloodType, MyMBTI);
        IntroduceC(MySteamLevel, MySteamYears, MySteamGameMount, MyFavoriteDrink, MyFavoriteHardDrink);

    }

    // Update is called once per frame
    void Update()
    {
        if (PageNumber <= 0)
        {
            PageNumber = 0;
        }

        if (PageNumber >= 5)
        {
            PageNumber = 4;
        }

        switch (PageNumber)
        {
            case 0:
                IntroduceText.text = "�� �Ұ��� �غ��ڽ��ϴ�.";
                break;

            case 1:
                IntroduceA(MyName, MyAge, MyOfficalNickName);
                break;

            case 2:
                IntroduceB(MyBirthYear, MyBirthMonth, MyBirthDate, MyHeight, MyBloodType, MyMBTI);
                break;

            case 3:
                IntroduceC(MySteamLevel, MySteamYears, MySteamGameMount, MyFavoriteDrink, MyFavoriteHardDrink);
                break;

            case 4:
                IntroduceText.text = "�� �Ұ��� ��Ĩ�ϴ�.";
                break;

            default:
                IntroduceText.text = "�� �Ұ��� �غ��ڽ��ϴ�.";
                break;
        }
    }


    public void Introduce1()
    {
        Debug.Log("�� �̸��� " + MyName + " �Դϴ�.");
        Debug.Log("�� ���̴� " + MyAge + " �� �̰�");
        Debug.Log("�� �г����� " + MyOfficalNickName + " �Դϴ�.");
    }

    public void Introduce2()
    {
        Debug.Log("�� ��������� " + MyBirthYear + "�� " + MyBirthMonth + "�� " + MyBirthDate + "�� �Դϴ�.");
        Debug.Log("�� Ű�� " + MyHeight + " cm �̰�");
        Debug.Log("�� �������� " + MyBloodType + " �� �Դϴ�.");
        Debug.Log("�� MBTI�� " + MyMBTI + ", �������� ������ Ÿ�� ����.");
    }

    public void Introduce3()
    {
        Debug.Log("�� ���� ������ " + MySteamLevel + " �Դϴ�");
        Debug.Log("�������� Ȱ���� ȶ���� " + MySteamYears + " �� �Դϴ�");
        Debug.Log("�������� �� ���� ���� ���� " + MySteamGameMount + " �� �Դϴ�.");
        Debug.Log("�����ϴ� ����Ʈ �帵ũ�� " + MyFavoriteDrink + " �Դϴ�.");
        Debug.Log("�����ϴ� �ϵ� �帵ũ�� " + MyFavoriteHardDrink + " �Դϴ�.");
    }



    public void IntroduceA(string MyName, int MyAge, string MyOfficalNickName)
    {
        IntroduceText.text = "�� �̸��� " + MyName + "�Դϴ�. \n" + "�� ���̴� " + MyAge + "�� �̰� \n" + "�� �г����� " + MyOfficalNickName + "�Դϴ�.";

        Debug.Log("�� �̸��� " + MyName + "�Դϴ�.");
        Debug.Log("�� ���̴� " + MyAge + "�� �̰�");
        Debug.Log("�� �г����� " + MyOfficalNickName + "�Դϴ�.");
    }

    public void IntroduceB(int MyBirthYear, int MyBirthMonth, int MyBirthDate, float MyHeight, char MyBloodType, string MyMBTI)
    {
        IntroduceText.text = "�� ��������� " + MyBirthYear + " �� " + MyBirthMonth + " �� " + MyBirthDate + " �� �Դϴ�. \n" + "�� Ű�� " + MyHeight + " cm �̰� \n" +
           "�� �������� " + MyBloodType + " �� �Դϴ� \n." + "�� MBTI�� " + MyMBTI + " , �������� ������ Ÿ�� ����.";

        Debug.Log("�� ��������� " + MyBirthYear + " �� " + MyBirthMonth + " �� " + MyBirthDate + " �� �Դϴ�.");
        Debug.Log("�� Ű�� " + MyHeight + " cm �̰�");
        Debug.Log("�� �������� " + MyBloodType + " �� �Դϴ�.");
        Debug.Log("�� MBTI�� " + MyMBTI + " , �������� ������ Ÿ�� ����.");
    }

    public void IntroduceC(int MySteamLevel, int MySteamYears, int MySteamGameMount, string MyFavoriteDrink, string MyFavoriteHardDrink)
    {
        IntroduceText.text = "�� ���� ������ " + MySteamLevel + " �Դϴ� \n." + "�������� Ȱ���� ȶ���� " + MySteamYears + " �� �Դϴ� \n" +
          "�������� �� ���� ���� ���� " + MySteamGameMount + " �� �Դϴ� \n" + "�����ϴ� ����Ʈ �帵ũ�� " + MyFavoriteDrink + " �Դϴ� \n." + "�����ϴ� �ϵ� �帵ũ�� " + MyFavoriteHardDrink + " �Դϴ�.";

        Debug.Log("�� ���� ������ " + MySteamLevel + " �Դϴ�");
        Debug.Log("�������� Ȱ���� ȶ���� " + MySteamYears + " �� �Դϴ�");
        Debug.Log("�������� �� ���� ���� ���� " + MySteamGameMount + " �� �Դϴ�.");
        Debug.Log("�����ϴ� ����Ʈ �帵ũ�� " + MyFavoriteDrink + " �Դϴ�.");
        Debug.Log("�����ϴ� �ϵ� �帵ũ�� " + MyFavoriteHardDrink + " �Դϴ�.");
    }

}
