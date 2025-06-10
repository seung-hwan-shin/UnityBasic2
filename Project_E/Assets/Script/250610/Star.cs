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

    // star += "★"; // 별
    //star += "　"; // 빈칸
    // star += "\n"; // 줄바꿈

    public void Phase1()
    {
        star = string.Empty;

        // 페이즈 1
        for (int i = 1; i < 6; i++) // 몇번째 줄인지 
        {
            // 1번째 줄이면 별이 1개 + 빈칸 4개 + 줄바꿈
            for (int a = 0; a < i; a++)
            {
                star += "★";
            }
            star += "\n";

        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;
        for (int i = 1; i < 6; i++) // 몇번째 줄인지 
        {
            
            for (int a = 0; a < 5 - i; a++)
            {
                star += "　";
            }
            for (int a = 0; a < i; a++)
            {
                star += "★";
            }

            star += "\n";
        }



        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3
        for (int i = 1; i < 10; i++) // 몇번째 줄인지 
        {
            
            if (i < 6)
            {
                for (int a = 0; a < i; a++) // 절댓값으로 별의 개수를 대칭으로 만들 수 있음.
                {
                    star += "★";
                }
                for (int a = 0; a < 5 - i; a++)
                {
                    star += "　";
                }
                star += "\n";
            }

            else
            {
                for (int a = 0; a < 5 - (i - 5); a++) // 5번째 줄부터 줄어드는 수
                {
                    star += "★";
                }
                for (int a = 0; a < i; a++)
                {
                    star += "　";
                }
                star += "\n";
            }
        }
        Debug.Log(star);
    }



    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4
        for (int i = 1; i < 10; i++) // 몇번째 줄인지 
        {
            
            if (i < 6)
            {
                for (int a = 0; a < 5 - i; a++)
                {
                    star +=  "　";
                }
                for (int a = 0; a < i; a++)
                {
                    star += "★";
                }
                star += "\n";
            }

            else
            {
                for (int a = 0; a < i - 5; a++)
                {
                    star += "　";
                }
                for (int a = 0; a < 5 - (i - 5); a++) // 5번째 줄부터 줄어드는 수
                {
                    star +=  "★";
                }
                star += "\n";
            }
        }

        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5
        for (int i = 1; i < 10; i++) // 몇번째 줄인지 
        {
            
            if (i < 6)
            {
                for (int a = 0; a < 5 - i; a++)
                {
                    star += "　";
                }
                for (int a = 0; a < 9 - (5 - i)*2; a++)
                {
                    star += "★";
                }
                for (int a = 0; a < 5 - i; a++)
                {
                    star += "　";
                }
                star += "\n";
            }

            else
            {
                for (int a = 0; a < i - 5; a++)
                {
                    star += "　";
                }
                for (int a = 0; a < 9 - (i - 5) * 2; a++)
                {
                    star += "★";
                }
                for (int a = 0; a < i - 5; a++)
                {
                    star += "　";
                }
                star += "\n";
            }
        }

        Debug.Log(star);
    }
    public void Phase6()
    {
        star = string.Empty;

        // 페이즈 6
        for (int i = 1; i < 10; i++) // 몇번째 줄인지 
        {

            if (i < 6)
            {
                for (int a = 0; a < 5 - i; a++)
                {
                    star += "★";
                }
                for (int a = 0; a < 9 - (5 - i) * 2; a++)
                {
                    star += "　";
                }
                for (int a = 0; a < 5 - i; a++)
                {
                    star += "★";
                }
                star += "\n";
            }

            else
            {
                for (int a = 0; a < i - 5; a++)
                {
                    star +=  "★";
                }
                for (int a = 0; a < 9 - (i - 5) * 2; a++)
                {
                    star += "　";
                }
                for (int a = 0; a < i - 5; a++)
                {
                    star += "★";
                }
                star += "\n";
            }
        }

        Debug.Log(star);
    }
}
