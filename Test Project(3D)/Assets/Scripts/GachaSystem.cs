using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GachaSystem : MonoBehaviour
{
    public int RandomRange;
    public TextMeshProUGUI GachaText;
    public int LegendaryCount;
    public int PickUpRange;
    private string PickedLegendaryName = "";

    enum GachaGrade
    {
        Common,
        Uncommon,
        Rare,
        SuperRare,
        Epic,
        SuperSuperRare,
        SuperSuperSuperRare,
        Legendary
    }

    GachaGrade GetGachaGrade(int RandomRangel)
    {
        if (RandomRange < 5)
            return GachaGrade.Legendary;
        else if (RandomRange < 10)
            return GachaGrade.SuperSuperSuperRare;
        else if (RandomRange < 20)
            return GachaGrade.SuperSuperRare;
        else if (RandomRange < 30)
            return GachaGrade.Epic;
        else if (RandomRange < 45)
            return GachaGrade.SuperRare;
        else if (RandomRange < 60)
            return GachaGrade.Rare;
        else if (RandomRange < 90)
            return GachaGrade.Uncommon;
        else
            return GachaGrade.Common;
    }

    void ApplyGachaResult(GachaGrade grade)
    {
        switch (grade)
        {
            case GachaGrade.Common:
                GachaText.color = new Color(0f, 0f, 0f);
                GachaText.text = "Common Picked.";
                break;

            case GachaGrade.Uncommon:
                GachaText.color = new Color(0f, 0f, 1f);
                GachaText.text = "Uncommon Picked.";
                break;

            case GachaGrade.Rare:
                GachaText.color = new Color(0.49f, 0f, 1f);
                GachaText.text = "Rare Picked!";
                break;

            case GachaGrade.SuperRare:
                GachaText.color = new Color(0.75f, 0f, 1f);
                GachaText.text = "Super Rare Picked!";
                break;

            case GachaGrade.Epic:
                GachaText.color = new Color(1f, 0f, 0f);
                GachaText.text = "Epic Picked!";
                break;

            case GachaGrade.SuperSuperRare:
                GachaText.color = new Color(0.86f, 0.39f, 0f);
                GachaText.text = "Super Super Rare Picked!";
                break;

            case GachaGrade.SuperSuperSuperRare:
                GachaText.color = new Color(0.86f, 0.39f, 0f);
                GachaText.text = "Super Super Super Rare Picked!";
                break;

            case GachaGrade.Legendary:
                GachaText.color = new Color(0.86f, 0.8f, 0f);
                if (PickedLegendaryName != "")
                {
                    GachaText.text = $"LEGENDARY PICKED!!!! \n ({PickedLegendaryName})";
                }
                else
                {
                    GachaText.text = "LEGENDARY PICKED!!!!";
                }
                break;

            default:
                GachaText.color = Color.gray;
                GachaText.text = "Invalid Grade.";
                break;
        }
    }




    void Awake()
    {
        RandomRange = Random.Range(0, 151);
        PickUpRange = Random.Range(0, 11);
    }

    void Start()
    {

        GachaGrade grade = GetGachaGrade(RandomRange);
        ApplyGachaResult(grade);


    }

    // Update is called once per frame
    void Update()
    {

    }


    public void GachaButton()
    {
        GachaGrade grade;

        if (LegendaryCount >= 30)
        {
            grade = GachaGrade.Legendary;
            LegendaryCount = 0;
        }
        else
        {
            RandomRange = Random.Range(0, 151);
            grade = GetGachaGrade(RandomRange);

            if (grade == GachaGrade.Legendary)
                LegendaryCount = 0;
            else
                LegendaryCount += 1;
        }

        // 전설 등급일 경우에만 PickUp 처리
        if (grade == GachaGrade.Legendary)
        {
            PickUpRange = Random.Range(0, 10); // 0, 1, 2
            switch (PickUpRange)
            {
                case 0:
                    PickedLegendaryName = "히아킨";
                    break;
                case 1:
                    PickedLegendaryName = "더 헤르타";
                    break;
                case 2:
                    PickedLegendaryName = "아케론";
                    break;
                default:
                    PickedLegendaryName = "4성 캐릭터들";
                    break;
            }
        }
        else
        {
            PickedLegendaryName = ""; // 전설이 아닐 때는 이름 없음
        }

        ApplyGachaResult(grade);
    }
}
