using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TextBox : MonoBehaviour
{
    public TextMeshProUGUI TextBoxText;
    private string NextText;
    public Image BG;
    public Sprite NextBG;
    public int PageCount;


    void Start()
    {
        Texts();
        PageCount = 1;
    }

    void Update()
    {
        Texts();

        if (PageCount >= 2)
        {
            TextBoxText.text = NextText;
        }

        if (PageCount >= 3)
        {
            PageCount = 3;
        }
    }



    public void OnClickButton()
    {
        PageCount += 1;
       // TextBoxText.text = NextText;
    }


    public void Texts()
    {
        if (PageCount == 2)
        {
            NextText = "하지만, 그게 뭐가 그리 중요한가? \n" + "어짜피 우린 모든 것이 끝날 때 까지, \n 보이는 악마들을 찍고 죽이면 그만인걸..";
        }

        if (PageCount >= 3)
        {
            BG.sprite = NextBG;
            NextText = "근데 이런 고민을 했다는 건, \n" + "네 놈도 악마라는 건가?... Rip and Tear...!";
        }
    }

}
