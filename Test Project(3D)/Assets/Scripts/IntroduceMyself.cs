using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IntroduceMyself : MonoBehaviour
{
    private string MyName = "양승화"; // 이름
    private string MyOfficalNickName = "별마리오군";
    private int MyAge = 32; // 나이
    private float MyHeight = 185.2f; // 키

    private int MyBirthYear = 1993; //태어난 년도
    private int MyBirthMonth = 4; // 태어난 월
    private int MyBirthDate = 29; // 태어난 일

    private string MyMBTI = "INFP"; // MBTI
    private char MyBloodType = 'O'; // 혈액형
    private int MySteamLevel = 88; // 현재 스팀 레벨
    private int MySteamYears = 20; // 스팀 내에서 활약한 년도
    private int MySteamGameMount = 544; // 스팀 게임 보유 수
    private string MyFavoriteDrink = "펩시 제로 라임"; //좋아하는 소프트 드링크
    private string MyFavoriteHardDrink = "기네스"; // 좋아하는 하드 드링크

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
                IntroduceText.text = "제 소개를 해보겠습니다.";
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
                IntroduceText.text = "제 소개를 마칩니다.";
                break;

            default:
                IntroduceText.text = "제 소개를 해보겠습니다.";
                break;
        }
    }


    public void Introduce1()
    {
        Debug.Log("제 이름은 " + MyName + " 입니다.");
        Debug.Log("제 나이는 " + MyAge + " 세 이고");
        Debug.Log("제 닉네임은 " + MyOfficalNickName + " 입니다.");
    }

    public void Introduce2()
    {
        Debug.Log("제 생년월일은 " + MyBirthYear + "년 " + MyBirthMonth + "월 " + MyBirthDate + "일 입니다.");
        Debug.Log("제 키는 " + MyHeight + " cm 이고");
        Debug.Log("제 혈액형은 " + MyBloodType + " 형 입니다.");
        Debug.Log("제 MBTI는 " + MyMBTI + ", 열정적인 중재자 타입 이죠.");
    }

    public void Introduce3()
    {
        Debug.Log("제 스팀 레벨은 " + MySteamLevel + " 입니다");
        Debug.Log("스팀에서 활약한 횃수는 " + MySteamYears + " 년 입니다");
        Debug.Log("스팀에서 제 게임 보유 수는 " + MySteamGameMount + " 개 입니다.");
        Debug.Log("좋아하는 소프트 드링크는 " + MyFavoriteDrink + " 입니다.");
        Debug.Log("좋아하는 하드 드링크는 " + MyFavoriteHardDrink + " 입니다.");
    }



    public void IntroduceA(string MyName, int MyAge, string MyOfficalNickName)
    {
        IntroduceText.text = "제 이름은 " + MyName + "입니다. \n" + "제 나이는 " + MyAge + "세 이고 \n" + "제 닉네임은 " + MyOfficalNickName + "입니다.";

        Debug.Log("제 이름은 " + MyName + "입니다.");
        Debug.Log("제 나이는 " + MyAge + "세 이고");
        Debug.Log("제 닉네임은 " + MyOfficalNickName + "입니다.");
    }

    public void IntroduceB(int MyBirthYear, int MyBirthMonth, int MyBirthDate, float MyHeight, char MyBloodType, string MyMBTI)
    {
        IntroduceText.text = "제 생년월일은 " + MyBirthYear + " 년 " + MyBirthMonth + " 월 " + MyBirthDate + " 일 입니다. \n" + "제 키는 " + MyHeight + " cm 이고 \n" +
           "제 혈액형은 " + MyBloodType + " 형 입니다 \n." + "제 MBTI는 " + MyMBTI + " , 열정적인 중재자 타입 이죠.";

        Debug.Log("제 생년월일은 " + MyBirthYear + " 년 " + MyBirthMonth + " 월 " + MyBirthDate + " 일 입니다.");
        Debug.Log("제 키는 " + MyHeight + " cm 이고");
        Debug.Log("제 혈액형은 " + MyBloodType + " 형 입니다.");
        Debug.Log("제 MBTI는 " + MyMBTI + " , 열정적인 중재자 타입 이죠.");
    }

    public void IntroduceC(int MySteamLevel, int MySteamYears, int MySteamGameMount, string MyFavoriteDrink, string MyFavoriteHardDrink)
    {
        IntroduceText.text = "제 스팀 레벨은 " + MySteamLevel + " 입니다 \n." + "스팀에서 활약한 횃수는 " + MySteamYears + " 년 입니다 \n" +
          "스팀에서 제 게임 보유 수는 " + MySteamGameMount + " 개 입니다 \n" + "좋아하는 소프트 드링크는 " + MyFavoriteDrink + " 입니다 \n." + "좋아하는 하드 드링크는 " + MyFavoriteHardDrink + " 입니다.";

        Debug.Log("제 스팀 레벨은 " + MySteamLevel + " 입니다");
        Debug.Log("스팀에서 활약한 횃수는 " + MySteamYears + " 년 입니다");
        Debug.Log("스팀에서 제 게임 보유 수는 " + MySteamGameMount + " 개 입니다.");
        Debug.Log("좋아하는 소프트 드링크는 " + MyFavoriteDrink + " 입니다.");
        Debug.Log("좋아하는 하드 드링크는 " + MyFavoriteHardDrink + " 입니다.");
    }

}
