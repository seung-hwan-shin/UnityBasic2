using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    // Start is called before the first frame update
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
        Phase6();
    }

    // star += "��"; // ��
    //star += "��"; // ��ĭ
    // star += "\n"; // �ٹٲ�

    public void Phase1()
    {
        star = string.Empty;

        // ������ 1
        for (int i = 1; i < 6; i++) // ���° ������ 
        {
            // 1��° ���̸� ���� 1�� + ��ĭ 4�� + �ٹٲ�
            for (int a = 0; a < i; a++)
            {
                star += "��";
            }
            star += "\n";

        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;
        for (int i = 1; i < 6; i++) // ���° ������ 
        {
            
            for (int a = 0; a < 5 - i; a++)
            {
                star += "��";
            }
            for (int a = 0; a < i; a++)
            {
                star += "��";
            }

            star += "\n";
        }



        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3
        for (int i = 1; i < 10; i++) // ���° ������ 
        {
            
            if (i < 6)
            {
                for (int a = 0; a < i; a++) // �������� ���� ������ ��Ī���� ���� �� ����.
                {
                    star += "��";
                }
                for (int a = 0; a < 5 - i; a++)
                {
                    star += "��";
                }
                star += "\n";
            }

            else
            {
                for (int a = 0; a < 5 - (i - 5); a++) // 5��° �ٺ��� �پ��� ��
                {
                    star += "��";
                }
                for (int a = 0; a < i; a++)
                {
                    star += "��";
                }
                star += "\n";
            }
        }
        Debug.Log(star);
    }



    public void Phase4()
    {
        star = string.Empty;

        // ������ 4
        for (int i = 1; i < 10; i++) // ���° ������ 
        {
            
            if (i < 6)
            {
                for (int a = 0; a < 5 - i; a++)
                {
                    star +=  "��";
                }
                for (int a = 0; a < i; a++)
                {
                    star += "��";
                }
                star += "\n";
            }

            else
            {
                for (int a = 0; a < i - 5; a++)
                {
                    star += "��";
                }
                for (int a = 0; a < 5 - (i - 5); a++) // 5��° �ٺ��� �پ��� ��
                {
                    star +=  "��";
                }
                star += "\n";
            }
        }

        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ������ 5
        for (int i = 1; i < 10; i++) // ���° ������ 
        {
            
            if (i < 6)
            {
                for (int a = 0; a < 5 - i; a++)
                {
                    star += "��";
                }
                for (int a = 0; a < 9 - (5 - i)*2; a++)
                {
                    star += "��";
                }
                for (int a = 0; a < 5 - i; a++)
                {
                    star += "��";
                }
                star += "\n";
            }

            else
            {
                for (int a = 0; a < i - 5; a++)
                {
                    star += "��";
                }
                for (int a = 0; a < 9 - (i - 5) * 2; a++)
                {
                    star += "��";
                }
                for (int a = 0; a < i - 5; a++)
                {
                    star += "��";
                }
                star += "\n";
            }
        }

        Debug.Log(star);
    }
    public void Phase6()
    {
        star = string.Empty;

        // ������ 6
        for (int i = 1; i < 10; i++) // ���° ������ 
        {

            if (i < 6)
            {
                for (int a = 0; a < 5 - i; a++)
                {
                    star += "��";
                }
                for (int a = 0; a < 9 - (5 - i) * 2; a++)
                {
                    star += "��";
                }
                for (int a = 0; a < 5 - i; a++)
                {
                    star += "��";
                }
                star += "\n";
            }

            else
            {
                for (int a = 0; a < i - 5; a++)
                {
                    star +=  "��";
                }
                for (int a = 0; a < 9 - (i - 5) * 2; a++)
                {
                    star += "��";
                }
                for (int a = 0; a < i - 5; a++)
                {
                    star += "��";
                }
                star += "\n";
            }
        }

        Debug.Log(star);
    }
}
