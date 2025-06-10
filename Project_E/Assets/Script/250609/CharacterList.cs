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
        // SSR 8종류
        GaChaCharacterSSR.Add("루미네");
        GaChaCharacterSSR.Add("호두");
        GaChaCharacterSSR.Add("모나");
        GaChaCharacterSSR.Add("각청");
        GaChaCharacterSSR.Add("감우");
        GaChaCharacterSSR.Add("치치");
        GaChaCharacterSSR.Add("요이미야");
        GaChaCharacterSSR.Add("푸리나");

        // SR 9종류
        GaChaCharacterSR.Add("엠버");
        GaChaCharacterSR.Add("향릉");
        GaChaCharacterSR.Add("신염");
        GaChaCharacterSR.Add("연비");
        GaChaCharacterSR.Add("바바라");
        GaChaCharacterSR.Add("설탕");
        GaChaCharacterSR.Add("피슬");
        GaChaCharacterSR.Add("노엘");
        GaChaCharacterSR.Add("운근");

    }

    
       
    public void RandomGaCha()
    {

        int number = 0;
        // int selectNumber = 0;
        while (number < 10)
        {
            int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 
            int randomSSR = Random.Range(0, GaChaCharacterSSR.Count);
            int randomSR = Random.Range(0, GaChaCharacterSR.Count);
            Debug.Log($"랜덤한 값은 : {randomValue} 입니다");

            if (8 <= count)
            {
                switch (selectNumber)
                {
                    case 0:
                        {
                            Debug.Log("확정으로 SSR 캐릭터 '각청'을 뽑았다!");
                        }
                        break;
                    case 1:
                        {
                            Debug.Log("확정으로 SSR 캐릭터 '호두'을 뽑았다!");
                        }
                        break;
                    case 2:
                        {
                            Debug.Log("확정으로 SSR 캐릭터 '모나'을 뽑았다!");
                        }
                        break;
                    default:
                        {
                            Debug.Log("확정으로 SSR 캐릭터 '감우'을 뽑았다!");
                        }
                        break;


                }
                count = 0;
            }
            else if (randomValue <= 30)
            {
                Debug.Log("SSR 캐릭터 " + GaChaCharacterSSR[randomSSR] + "를(을) 뽑았습니다.");
            }
            else  
            {
                Debug.Log("SR 캐릭터 " + GaChaCharacterSR[randomSR] + "를(을) 뽑았습니다.");
            }
           

            count++;
            number++;



        }
    }

}
