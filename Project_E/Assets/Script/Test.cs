using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour // ������ ��Ű�� ���� �پ��ִ� ��ũ��Ʈ
{
    private string myname = "�Ž�ȯ";
    private int age = 29;
    private string living = "��õ��";
    private string mbti = "ISFJ";
    private string job = "QA";

    public void Start()
    {
        UnityEngine.Debug.Log("���� �̸��� " + myname + "�Դϴ�.");
        UnityEngine.Debug.Log("���� ���̴� " + age + "�Դϴ�.");
        UnityEngine.Debug.Log("���� " + living + "�� ��� �ֽ��ϴ�.");
        UnityEngine.Debug.Log("���� MBTI�� " + mbti + "�Դϴ�.");
        UnityEngine.Debug.Log("���� ����ϴ� ������ " + job + "�Դϴ�.");
    }
   
}
