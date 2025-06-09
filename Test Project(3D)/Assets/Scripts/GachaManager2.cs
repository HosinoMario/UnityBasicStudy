using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GachaManager2 : MonoBehaviour
{
    public int RandomRange;
    public int PickUpRange;
    private int PickUpCount;
    public TextMeshProUGUI MoneyText;
    public TextMeshProUGUI GachaText;
    public TextMeshProUGUI PickUpCountText;
    public int Money;



    // Start is called before the first frame update
    void Start()
    {
        Money = 20000;
        PickUpCount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = "현재 재화 : " + Money;
        PickUpCountText.text = "50번째 카운트에선 픽업 확정! \n 현재 픽업 카운트 : " + PickUpCount;

        if (Money < 0)
        {
            Money = 0;
        }
    }

    public void GatchButton2()
    {
        if (Money >= 200)
        {
            Money -= 200;
            PickUpCount += 1;

            if (PickUpCount >= 50)
            {
                Debug.Log("픽업 카운트 도달!");
                PickUpRange = Random.Range(0, 4);
                PickUpCount = 0;

                // 픽업 확정 처리
                switch (PickUpRange)
                {
                    case 0:
                        GachaText.text = "히아킨 확정!";
                        Debug.Log("히아킨 확정 획득");
                        break;
                    case 1:
                        GachaText.text = "더 헤르타 확정!";
                        Debug.Log("더 헤르타 확정 획득");
                        break;
                    case 2:
                        GachaText.text = "사이퍼 확정!";
                        Debug.Log("사이퍼 확정 획득");
                        break;
                    case 3:
                        GachaText.text = "아케론 확정!";
                        Debug.Log("아케론 확정 획득");
                        break;
                }
                return; // 확정 처리했으므로 더 이상 진행하지 않음
            }

            RandomRange = Random.Range(0, 100);

            if (RandomRange >= 75)
            {
                PickUpRange = Random.Range(0, 11);

                switch (PickUpRange)
                {
                    case 0:
                        GachaText.text = "히아킨 획득!";
                        Debug.Log("히아킨 획득");
                        break;
                    case 1:
                        GachaText.text = "더 헤르타 획득!";
                        Debug.Log("더 헤르타 획득");
                        break;
                    case 2:
                        GachaText.text = "사이퍼 획득!";
                        Debug.Log("사이퍼 획득");
                        break;
                    case 3:
                        GachaText.text = "아케론 획득!";
                        Debug.Log("아케론 획득");
                        break;
                    default:
                        GachaText.text = "통상 5성 획득!";
                        Debug.Log("통상 5성 캐릭터 획득");
                        break;
                }
            }
            else
            {
                Debug.Log("5성 획득 실패!");
            }
        }
        else
        {
            Debug.Log("재화가 없습니다. 현질을 더 하시길 바랍니다");
        }
    }

    public void GachaTenTimes() // for문 버전
    {

        if (Money >= 2000)
        {
            for (int i = 0; i < 10; i++)
            {
                Money -= 200;
                PickUpCount += 1;

                if (PickUpCount >= 50)
                {
                    Debug.Log("픽업 카운트 도달!");
                    PickUpRange = Random.Range(0, 4);
                    PickUpCount = 0;

                    // 픽업 확정 처리
                    switch (PickUpRange)
                    {
                        case 0:
                            GachaText.text = "히아킨 확정!";
                            Debug.Log("히아킨 확정 획득");
                            break;
                        case 1:
                            GachaText.text = "더 헤르타 확정!";
                            Debug.Log("더 헤르타 확정 획득");
                            break;
                        case 2:
                            GachaText.text = "사이퍼 확정!";
                            Debug.Log("사이퍼 확정 획득");
                            break;
                        case 3:
                            GachaText.text = "아케론 확정!";
                            Debug.Log("아케론 확정 획득");
                            break;
                    }
                    return; // 확정 처리했으므로 더 이상 진행하지 않음
                }

                RandomRange = Random.Range(0, 100);

                if (RandomRange >= 75)
                {
                    PickUpRange = Random.Range(0, 11);

                    switch (PickUpRange)
                    {
                        case 0:
                            GachaText.text = "히아킨 획득!";
                            Debug.Log("히아킨 획득");
                            break;
                        case 1:
                            GachaText.text = "더 헤르타 획득!";
                            Debug.Log("더 헤르타 획득");
                            break;
                        case 2:
                            GachaText.text = "사이퍼 획득!";
                            Debug.Log("사이퍼 획득");
                            break;
                        case 3:
                            GachaText.text = "아케론 획득!";
                            Debug.Log("아케론 획득");
                            break;
                        default:
                            GachaText.text = "통상 5성 획득!";
                            Debug.Log("통상 5성 캐릭터 획득");
                            break;
                    }
                }
                else
                {
                    Debug.Log("5성 획득 실패!");
                }
            }

        }

        else
        {
            Debug.Log("재화가 없습니다. 현질을 더 하시길 바랍니다");
        }
    }

    public void GachaTenTimes2() // while문 버전
     {
        if (Money >= 2000)
        {
            int i = 0; // 반복 카운터

            while (i < 10)
            {
                Money -= 200;
                PickUpCount += 1;

                if (PickUpCount >= 50)
                {
                    Debug.Log("픽업 카운트 도달!");
                    PickUpRange = Random.Range(0, 4);
                    PickUpCount = 0;

                    switch (PickUpRange)
                    {
                        case 0:
                            GachaText.text = "히아킨 확정!";
                            Debug.Log("히아킨 확정 획득");
                            break;
                        case 1:
                            GachaText.text = "더 헤르타 확정!";
                            Debug.Log("더 헤르타 확정 획득");
                            break;
                        case 2:
                            GachaText.text = "사이퍼 확정!";
                            Debug.Log("사이퍼 확정 획득");
                            break;
                        case 3:
                            GachaText.text = "아케론 확정!";
                            Debug.Log("아케론 확정 획득");
                            break;
                    }
                    return; 
                }

                RandomRange = Random.Range(0, 100);

                if (RandomRange >= 75)
                {
                    PickUpRange = Random.Range(0, 11);

                    switch (PickUpRange)
                    {
                        case 0:
                            GachaText.text = "히아킨 획득!";
                            Debug.Log("히아킨 획득");
                            break;
                        case 1:
                            GachaText.text = "더 헤르타 획득!";
                            Debug.Log("더 헤르타 획득");
                            break;
                        case 2:
                            GachaText.text = "사이퍼 획득!";
                            Debug.Log("사이퍼 획득");
                            break;
                        case 3:
                            GachaText.text = "아케론 획득!";
                            Debug.Log("아케론 획득");
                            break;
                        default:
                            GachaText.text = "통상 5성 획득!";
                            Debug.Log("통상 5성 캐릭터 획득");
                            break;
                    }
                }
                else
                {
                    Debug.Log("5성 획득 실패!");
                }

                i++;
            }
        }

        else
        {
            Debug.Log("재화가 없습니다. 현질을 더 하시길 바랍니다");
        }
     }

}

