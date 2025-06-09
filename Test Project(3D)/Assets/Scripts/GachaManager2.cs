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
        MoneyText.text = "���� ��ȭ : " + Money;
        PickUpCountText.text = "50��° ī��Ʈ���� �Ⱦ� Ȯ��! \n ���� �Ⱦ� ī��Ʈ : " + PickUpCount;

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
                Debug.Log("�Ⱦ� ī��Ʈ ����!");
                PickUpRange = Random.Range(0, 4);
                PickUpCount = 0;

                // �Ⱦ� Ȯ�� ó��
                switch (PickUpRange)
                {
                    case 0:
                        GachaText.text = "����Ų Ȯ��!";
                        Debug.Log("����Ų Ȯ�� ȹ��");
                        break;
                    case 1:
                        GachaText.text = "�� �츣Ÿ Ȯ��!";
                        Debug.Log("�� �츣Ÿ Ȯ�� ȹ��");
                        break;
                    case 2:
                        GachaText.text = "������ Ȯ��!";
                        Debug.Log("������ Ȯ�� ȹ��");
                        break;
                    case 3:
                        GachaText.text = "���ɷ� Ȯ��!";
                        Debug.Log("���ɷ� Ȯ�� ȹ��");
                        break;
                }
                return; // Ȯ�� ó�������Ƿ� �� �̻� �������� ����
            }

            RandomRange = Random.Range(0, 100);

            if (RandomRange >= 75)
            {
                PickUpRange = Random.Range(0, 11);

                switch (PickUpRange)
                {
                    case 0:
                        GachaText.text = "����Ų ȹ��!";
                        Debug.Log("����Ų ȹ��");
                        break;
                    case 1:
                        GachaText.text = "�� �츣Ÿ ȹ��!";
                        Debug.Log("�� �츣Ÿ ȹ��");
                        break;
                    case 2:
                        GachaText.text = "������ ȹ��!";
                        Debug.Log("������ ȹ��");
                        break;
                    case 3:
                        GachaText.text = "���ɷ� ȹ��!";
                        Debug.Log("���ɷ� ȹ��");
                        break;
                    default:
                        GachaText.text = "��� 5�� ȹ��!";
                        Debug.Log("��� 5�� ĳ���� ȹ��");
                        break;
                }
            }
            else
            {
                Debug.Log("5�� ȹ�� ����!");
            }
        }
        else
        {
            Debug.Log("��ȭ�� �����ϴ�. ������ �� �Ͻñ� �ٶ��ϴ�");
        }
    }

    public void GachaTenTimes() // for�� ����
    {

        if (Money >= 2000)
        {
            for (int i = 0; i < 10; i++)
            {
                Money -= 200;
                PickUpCount += 1;

                if (PickUpCount >= 50)
                {
                    Debug.Log("�Ⱦ� ī��Ʈ ����!");
                    PickUpRange = Random.Range(0, 4);
                    PickUpCount = 0;

                    // �Ⱦ� Ȯ�� ó��
                    switch (PickUpRange)
                    {
                        case 0:
                            GachaText.text = "����Ų Ȯ��!";
                            Debug.Log("����Ų Ȯ�� ȹ��");
                            break;
                        case 1:
                            GachaText.text = "�� �츣Ÿ Ȯ��!";
                            Debug.Log("�� �츣Ÿ Ȯ�� ȹ��");
                            break;
                        case 2:
                            GachaText.text = "������ Ȯ��!";
                            Debug.Log("������ Ȯ�� ȹ��");
                            break;
                        case 3:
                            GachaText.text = "���ɷ� Ȯ��!";
                            Debug.Log("���ɷ� Ȯ�� ȹ��");
                            break;
                    }
                    return; // Ȯ�� ó�������Ƿ� �� �̻� �������� ����
                }

                RandomRange = Random.Range(0, 100);

                if (RandomRange >= 75)
                {
                    PickUpRange = Random.Range(0, 11);

                    switch (PickUpRange)
                    {
                        case 0:
                            GachaText.text = "����Ų ȹ��!";
                            Debug.Log("����Ų ȹ��");
                            break;
                        case 1:
                            GachaText.text = "�� �츣Ÿ ȹ��!";
                            Debug.Log("�� �츣Ÿ ȹ��");
                            break;
                        case 2:
                            GachaText.text = "������ ȹ��!";
                            Debug.Log("������ ȹ��");
                            break;
                        case 3:
                            GachaText.text = "���ɷ� ȹ��!";
                            Debug.Log("���ɷ� ȹ��");
                            break;
                        default:
                            GachaText.text = "��� 5�� ȹ��!";
                            Debug.Log("��� 5�� ĳ���� ȹ��");
                            break;
                    }
                }
                else
                {
                    Debug.Log("5�� ȹ�� ����!");
                }
            }

        }

        else
        {
            Debug.Log("��ȭ�� �����ϴ�. ������ �� �Ͻñ� �ٶ��ϴ�");
        }
    }

    public void GachaTenTimes2() // while�� ����
     {
        if (Money >= 2000)
        {
            int i = 0; // �ݺ� ī����

            while (i < 10)
            {
                Money -= 200;
                PickUpCount += 1;

                if (PickUpCount >= 50)
                {
                    Debug.Log("�Ⱦ� ī��Ʈ ����!");
                    PickUpRange = Random.Range(0, 4);
                    PickUpCount = 0;

                    switch (PickUpRange)
                    {
                        case 0:
                            GachaText.text = "����Ų Ȯ��!";
                            Debug.Log("����Ų Ȯ�� ȹ��");
                            break;
                        case 1:
                            GachaText.text = "�� �츣Ÿ Ȯ��!";
                            Debug.Log("�� �츣Ÿ Ȯ�� ȹ��");
                            break;
                        case 2:
                            GachaText.text = "������ Ȯ��!";
                            Debug.Log("������ Ȯ�� ȹ��");
                            break;
                        case 3:
                            GachaText.text = "���ɷ� Ȯ��!";
                            Debug.Log("���ɷ� Ȯ�� ȹ��");
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
                            GachaText.text = "����Ų ȹ��!";
                            Debug.Log("����Ų ȹ��");
                            break;
                        case 1:
                            GachaText.text = "�� �츣Ÿ ȹ��!";
                            Debug.Log("�� �츣Ÿ ȹ��");
                            break;
                        case 2:
                            GachaText.text = "������ ȹ��!";
                            Debug.Log("������ ȹ��");
                            break;
                        case 3:
                            GachaText.text = "���ɷ� ȹ��!";
                            Debug.Log("���ɷ� ȹ��");
                            break;
                        default:
                            GachaText.text = "��� 5�� ȹ��!";
                            Debug.Log("��� 5�� ĳ���� ȹ��");
                            break;
                    }
                }
                else
                {
                    Debug.Log("5�� ȹ�� ����!");
                }

                i++;
            }
        }

        else
        {
            Debug.Log("��ȭ�� �����ϴ�. ������ �� �Ͻñ� �ٶ��ϴ�");
        }
     }

}

