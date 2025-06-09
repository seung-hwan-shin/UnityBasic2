using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    // Start is called before the first frame update
    int count;

    private void Awake()
    {
        count = 0;
    }

    // [�� �ٿ�]
    // ������ �� 1~100 ���̿� ���� �����
    // ������ ���⶧ ���� �ݺ�





    public void GachaTen()
    {
        int number = 0;
        while (number < 10)
        {
            int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

            Debug.Log($"������ ���� : {randomValue} �Դϴ�");
            // count 81
            if (8 <= count)
            {
                Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
                count = 0;
            }
            else if (randomValue <= 10) // 1 ~ 10 -> 10%
            {
                Debug.Log("'��û'�� �̾Ҵ�!");
            }
            else if (randomValue <= 30) // 11 ~ 30
            {
                Debug.Log("'��'�� �̾Ҵ�!");
            }
            else if (randomValue <= 50) // 11 ~ 30
            {
                Debug.Log("'ȣ��'�� �̾Ҵ�!");
            }
            else if (randomValue <= 70) // 11 ~ 30
            {
                Debug.Log("'����'�� �̾Ҵ�!");
            }
            else
            {
                Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
            }

            count++;
            number++;
        }
        
        
        for (int i = 0; i < 10; i++)
        {
            
        }

    
    }

    public void Gacha()
    {
        // Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!
        // Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
        // ������ 70% Ȯ���� 'ġġ'�� �̾ƹ��ȴ�!

        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        Debug.Log($"������ ���� : {randomValue} �Դϴ�");
        // count 81
        if (8 <= count)
        {
            Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
            count = 0;
        }
        else if (randomValue <= 10) // 1 ~ 10 -> 10%
        {
            Debug.Log("'��û'�� �̾Ҵ�!");
        }
        else if (randomValue <= 30) // 11 ~ 30
        {
            Debug.Log("'��'�� �̾Ҵ�!");
        }
        else if (randomValue <= 50) // 11 ~ 30
        {
            Debug.Log("'ȣ��'�� �̾Ҵ�!");
        }
        else if (randomValue <= 70) // 11 ~ 30
        {
            Debug.Log("'����'�� �̾Ҵ�!");
        }
        else
        {
            Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
        }

        count++;
    }
    // if -> switch ������ ������ ����

    public int selectNumber = 0;
    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        int selectNumber = 0;

        switch (selectNumber) //0
        {
            case 0:
                // ���� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 1:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 2:
                // ��ȫ �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            default:
                // �Ķ� �Ӹ� ���� ĳ���Ͱ� ���´�.
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ� ����'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;
        }
    }

    
}