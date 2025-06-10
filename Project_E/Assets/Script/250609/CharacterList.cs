using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterList : MonoBehaviour
{
    private void Awake()
    {
        count = 0;
    }

    List<string> GaChaCharacterSSR = new List<string>();
    List<string> GaChaCharacterSR = new List<string>();
    int count = 0;
    public int selectNumber = 0;

    void Start()
    {
        // SSR 8����
        GaChaCharacterSSR.Add("��̳�");
        GaChaCharacterSSR.Add("ȣ��");
        GaChaCharacterSSR.Add("��");
        GaChaCharacterSSR.Add("��û");
        GaChaCharacterSSR.Add("����");
        GaChaCharacterSSR.Add("ġġ");
        GaChaCharacterSSR.Add("���̹̾�");
        GaChaCharacterSSR.Add("Ǫ����");

        // SR 9����
        GaChaCharacterSR.Add("����");
        GaChaCharacterSR.Add("�⸪");
        GaChaCharacterSR.Add("�ſ�");
        GaChaCharacterSR.Add("����");
        GaChaCharacterSR.Add("�ٹٶ�");
        GaChaCharacterSR.Add("����");
        GaChaCharacterSR.Add("�ǽ�");
        GaChaCharacterSR.Add("�뿤");
        GaChaCharacterSR.Add("���");

    }

    
       
    public void RandomGaCha()
    {

        int number = 0;
        // int selectNumber = 0;
        while (number < 10)
        {
            int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 
            int randomSSR = Random.Range(0, GaChaCharacterSSR.Count);
            int randomSR = Random.Range(0, GaChaCharacterSR.Count);
            Debug.Log($"������ ���� : {randomValue} �Դϴ�");

            if (8 <= count)
            {
                switch (selectNumber)
                {
                    case 0:
                        {
                            Debug.Log("Ȯ������ SSR ĳ���� '��û'�� �̾Ҵ�!");
                        }
                        break;
                    case 1:
                        {
                            Debug.Log("Ȯ������ SSR ĳ���� 'ȣ��'�� �̾Ҵ�!");
                        }
                        break;
                    case 2:
                        {
                            Debug.Log("Ȯ������ SSR ĳ���� '��'�� �̾Ҵ�!");
                        }
                        break;
                    default:
                        {
                            Debug.Log("Ȯ������ SSR ĳ���� '����'�� �̾Ҵ�!");
                        }
                        break;


                }
                count = 0;
            }
            else if (randomValue <= 30)
            {
                Debug.Log("SSR ĳ���� " + GaChaCharacterSSR[randomSSR] + "��(��) �̾ҽ��ϴ�.");
            }
            else  
            {
                Debug.Log("SR ĳ���� " + GaChaCharacterSR[randomSR] + "��(��) �̾ҽ��ϴ�.");
            }
           

            count++;
            number++;



        }
    }

}
