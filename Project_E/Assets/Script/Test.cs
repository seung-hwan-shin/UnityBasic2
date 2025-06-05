using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour // 동작을 시키기 위해 붙어있는 스크립트
{
    private string myname = "신승환";
    private int age = 29;
    private string living = "부천시";
    private string mbti = "ISFJ";
    private string job = "QA";

    public void Start()
    {
        UnityEngine.Debug.Log("저의 이름은 " + myname + "입니다.");
        UnityEngine.Debug.Log("저의 나이는 " + age + "입니다.");
        UnityEngine.Debug.Log("현재 " + living + "에 살고 있습니다.");
        UnityEngine.Debug.Log("저의 MBTI는 " + mbti + "입니다.");
        UnityEngine.Debug.Log("제가 희망하는 직무는 " + job + "입니다.");
    }
   
}
