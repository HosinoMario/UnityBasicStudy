using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GachaArrayandList : MonoBehaviour
{
    public int RandomRange;
    public int PickUpRange;
    private int PickUpCount;

    List<string> CharacterListA = new List<string>(); //통상 + 픽업 리스트
    List<string> CharacterListB = new List<string>(); // 픽업 리스트

    public TextMeshProUGUI MoneyText;
    public TextMeshProUGUI GachaText;
    public TextMeshProUGUI PickUpCountText;
    public int Money;

    // Start is called before the first frame update
    void Start()
    {
        Money = 200000;
        PickUpCount = 0;

        CharacterListA.Add("-스페셜 드리머-  스페셜 위크");
        CharacterListA.Add("-사일런트 이노센트-  사일런스 스즈카");
        CharacterListA.Add("-톱 오브 조이풀-  토카이 테이오");
        CharacterListA.Add("-톱 오브 블루-  다이와 스칼렛");
        CharacterListA.Add("-와일드 톱 기어-  보드카");

        CharacterListA.Add("-레드 스트라이프-  골드 쉽");
        CharacterListA.Add("-사쿠라, 나아가라!-  사쿠라 바쿠신 오");
        CharacterListA.Add("-화창한 1등상-  하루 우라라");
        CharacterListA.Add("-스타라이트 비트-  오구리 캡");
        CharacterListA.Add("-엘레강스 라인-  메지로 맥퀸");

        CharacterListA.Add("-와일드 프론티어-  타이키 셔틀");
        CharacterListA.Add("-금상 금화가마-  키타산 블랙");
        CharacterListA.Add("-킹 오브 에메랄드-  킹 헤일로");
        CharacterListA.Add("-tach-nology-  아그네스 타키온");
        CharacterListA.Add("-포인세티아 리본-  나이스 네이처");

        CharacterListA.Add("-Bubblegum Memories-  타이키 셔틀 (피크닉)");
        CharacterListA.Add("-주역 경사스러운 학의 뜻-  키타산 블랙 (신년)");
        CharacterListA.Add("-일본 최고의 총대장-  스폐셜 위크 (일본 총대장)");
        CharacterListA.Add("-RUN! 럼블! 런처!-  골드 쉽 (수영복)");
        CharacterListA.Add("-새해의 화창함 활짝 핀 벛꽃-  하루 우라라 (신년)");

        CharacterListB.Add("-Bubblegum Memories-  타이키 셔틀 (피크닉)");
        CharacterListB.Add("-주역 경사스러운 학의 뜻-  키타산 블랙 (신년)");
        CharacterListB.Add("-일본 최고의 총대장-  스폐셜 위크 (일본 총대장)");
        CharacterListB.Add("-RUN! 럼블! 런처!-  골드 쉽 (수영복)");
        CharacterListB.Add("-새해의 화창함 활짝 핀 벛꽃-  하루 우라라 (신년)");
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

    public void OneGatchaButton()
    {
        Debug.Log("현재 재화 : " + Money);
        Debug.Log("50번째 카운트에선 픽업 확정! \n 현재 픽업 카운트 : " + PickUpCount);

        if (Money >= 200)
        {
            Money -= 200;
            PickUpCount += 1;

            if (PickUpCount >= 50)
            {
                Debug.Log("픽업 카운트 도달!");
                PickUpRange = Random.Range(0, CharacterListB.Count);

                GachaText.color = Color.yellow;
                GachaText.text = CharacterListB[PickUpRange] + " 획득!";
                Debug.Log(CharacterListB[PickUpRange] + " 획득!");
                PickUpCount = 0;
            }
            else
            {
                PickUpRange = Random.Range(0, CharacterListA.Count);
                string result = CharacterListA[PickUpRange];
                GachaText.text = CharacterListA[PickUpRange] + " 획득!";

                if (CharacterListB.Contains(result))
                {
                    GachaText.color = Color.yellow; // 픽업 캐릭터이면 노란색 텍스트
                }
                else
                {
                    GachaText.color = Color.white; // 통상이면 하얀색 텍스트
                }

                Debug.Log(CharacterListA[PickUpRange] + " 획득!");
            }
        }
        else
        {
            Debug.Log("재화가 없습니다. 현질을 더 하시길 바랍니다");
        }
    }

    public void TenGachaButton() // for문 버전
    {
        Debug.Log("현재 재화 : " + Money);
        Debug.Log("50번째 카운트에선 픽업 확정! \n 현재 픽업 카운트 : " + PickUpCount);

        if (Money >= 2000)
        {
            for (int i = 0; i < 10; i++)
            {
                if (PickUpCount >= 50)
                {
                    Debug.Log("픽업 카운트 도달!");
                    PickUpRange = Random.Range(0, CharacterListB.Count);
                    GachaText.text = CharacterListB[PickUpRange] + " 획득!";
                    Debug.Log(CharacterListB[PickUpRange] + " 획득!");
                    PickUpCount = 0;
                }
                else
                {
                    PickUpRange = Random.Range(0, CharacterListA.Count);
                    string result = CharacterListA[PickUpRange];
                    GachaText.text = CharacterListA[PickUpRange] + " 획득!";

                    if (CharacterListB.Contains(result))
                    {
                        GachaText.color = Color.yellow;
                    }
                    else
                    {
                        GachaText.color = Color.white;
                    }

                    Debug.Log(CharacterListA[PickUpRange] + " 획득!");
                }
            }
        }
        else
        {
            Debug.Log("재화가 없습니다. 현질을 더 하시길 바랍니다");
        }
    }
}
