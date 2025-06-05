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
            NextText = "������, �װ� ���� �׸� �߿��Ѱ�? \n" + "��¥�� �츰 ��� ���� ���� �� ����, \n ���̴� �Ǹ����� ��� ���̸� �׸��ΰ�..";
        }

        if (PageCount >= 3)
        {
            BG.sprite = NextBG;
            NextText = "�ٵ� �̷� ����� �ߴٴ� ��, \n" + "�� �� �Ǹ���� �ǰ�?... Rip and Tear...!";
        }
    }

}
