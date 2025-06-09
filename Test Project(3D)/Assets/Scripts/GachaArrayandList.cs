using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GachaArrayandList : MonoBehaviour
{
    public int RandomRange;
    public int PickUpRange;
    private int PickUpCount;

    List<string> CharacterListA = new List<string>(); //��� + �Ⱦ� ����Ʈ
    List<string> CharacterListB = new List<string>(); // �Ⱦ� ����Ʈ

    public TextMeshProUGUI MoneyText;
    public TextMeshProUGUI GachaText;
    public TextMeshProUGUI PickUpCountText;
    public int Money;

    // Start is called before the first frame update
    void Start()
    {
        Money = 200000;
        PickUpCount = 0;

        CharacterListA.Add("-����� �帮��-  ����� ��ũ");
        CharacterListA.Add("-���Ϸ�Ʈ �̳뼾Ʈ-  ���Ϸ��� ����ī");
        CharacterListA.Add("-�� ���� ����Ǯ-  ��ī�� ���̿�");
        CharacterListA.Add("-�� ���� ���-  ���̿� ��Į��");
        CharacterListA.Add("-���ϵ� �� ���-  ����ī");

        CharacterListA.Add("-���� ��Ʈ������-  ��� ��");
        CharacterListA.Add("-�����, ���ư���!-  ����� ����� ��");
        CharacterListA.Add("-ȭâ�� 1���-  �Ϸ� ����");
        CharacterListA.Add("-��Ÿ����Ʈ ��Ʈ-  ������ ĸ");
        CharacterListA.Add("-�������� ����-  ������ ����");

        CharacterListA.Add("-���ϵ� ����Ƽ��-  Ÿ��Ű ��Ʋ");
        CharacterListA.Add("-�ݻ� ��ȭ����-  ŰŸ�� ��");
        CharacterListA.Add("-ŷ ���� ���޶���-  ŷ ���Ϸ�");
        CharacterListA.Add("-tach-nology-  �Ʊ׳׽� ŸŰ��");
        CharacterListA.Add("-���μ�Ƽ�� ����-  ���̽� ����ó");

        CharacterListA.Add("-Bubblegum Memories-  Ÿ��Ű ��Ʋ (��ũ��)");
        CharacterListA.Add("-�ֿ� ��罺���� ���� ��-  ŰŸ�� �� (�ų�)");
        CharacterListA.Add("-�Ϻ� �ְ��� �Ѵ���-  ����� ��ũ (�Ϻ� �Ѵ���)");
        CharacterListA.Add("-RUN! ����! ��ó!-  ��� �� (������)");
        CharacterListA.Add("-������ ȭâ�� Ȱ¦ �� ����-  �Ϸ� ���� (�ų�)");

        CharacterListB.Add("-Bubblegum Memories-  Ÿ��Ű ��Ʋ (��ũ��)");
        CharacterListB.Add("-�ֿ� ��罺���� ���� ��-  ŰŸ�� �� (�ų�)");
        CharacterListB.Add("-�Ϻ� �ְ��� �Ѵ���-  ����� ��ũ (�Ϻ� �Ѵ���)");
        CharacterListB.Add("-RUN! ����! ��ó!-  ��� �� (������)");
        CharacterListB.Add("-������ ȭâ�� Ȱ¦ �� ����-  �Ϸ� ���� (�ų�)");
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = "���� ��ȭ : " + Money;
        PickUpCountText.text = "50��° ī��Ʈ���� �Ⱦ� Ȯ��! \n ���� �Ⱦ� ī��Ʈ : " + PickUpCount;

        if (Money < 0)
        {
            Money = 0;
        }
    }

    public void OneGatchaButton()
    {
        Debug.Log("���� ��ȭ : " + Money);
        Debug.Log("50��° ī��Ʈ���� �Ⱦ� Ȯ��! \n ���� �Ⱦ� ī��Ʈ : " + PickUpCount);

        if (Money >= 200)
        {
            Money -= 200;
            PickUpCount += 1;

            if (PickUpCount >= 50)
            {
                Debug.Log("�Ⱦ� ī��Ʈ ����!");
                PickUpRange = Random.Range(0, CharacterListB.Count);

                GachaText.color = Color.yellow;
                GachaText.text = CharacterListB[PickUpRange] + " ȹ��!";
                Debug.Log(CharacterListB[PickUpRange] + " ȹ��!");
                PickUpCount = 0;
            }
            else
            {
                PickUpRange = Random.Range(0, CharacterListA.Count);
                string result = CharacterListA[PickUpRange];
                GachaText.text = CharacterListA[PickUpRange] + " ȹ��!";

                if (CharacterListB.Contains(result))
                {
                    GachaText.color = Color.yellow; // �Ⱦ� ĳ�����̸� ����� �ؽ�Ʈ
                }
                else
                {
                    GachaText.color = Color.white; // ����̸� �Ͼ�� �ؽ�Ʈ
                }

                Debug.Log(CharacterListA[PickUpRange] + " ȹ��!");
            }
        }
        else
        {
            Debug.Log("��ȭ�� �����ϴ�. ������ �� �Ͻñ� �ٶ��ϴ�");
        }
    }

    public void TenGachaButton() // for�� ����
    {
        Debug.Log("���� ��ȭ : " + Money);
        Debug.Log("50��° ī��Ʈ���� �Ⱦ� Ȯ��! \n ���� �Ⱦ� ī��Ʈ : " + PickUpCount);

        if (Money >= 2000)
        {
            for (int i = 0; i < 10; i++)
            {
                if (PickUpCount >= 50)
                {
                    Debug.Log("�Ⱦ� ī��Ʈ ����!");
                    PickUpRange = Random.Range(0, CharacterListB.Count);
                    GachaText.text = CharacterListB[PickUpRange] + " ȹ��!";
                    Debug.Log(CharacterListB[PickUpRange] + " ȹ��!");
                    PickUpCount = 0;
                }
                else
                {
                    PickUpRange = Random.Range(0, CharacterListA.Count);
                    string result = CharacterListA[PickUpRange];
                    GachaText.text = CharacterListA[PickUpRange] + " ȹ��!";

                    if (CharacterListB.Contains(result))
                    {
                        GachaText.color = Color.yellow;
                    }
                    else
                    {
                        GachaText.color = Color.white;
                    }

                    Debug.Log(CharacterListA[PickUpRange] + " ȹ��!");
                }
            }
        }
        else
        {
            Debug.Log("��ȭ�� �����ϴ�. ������ �� �Ͻñ� �ٶ��ϴ�");
        }
    }
}
