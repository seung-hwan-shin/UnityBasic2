using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetHP : MonoBehaviour
{
    // �ý��� ��ȹ ����
    public TextMeshProUGUI Txt_HP;
    public TextMeshProUGUI Txt_text;

    public Image Img_HPbar;

    public int MaxHP;
    float nowHP;
    // �ּ�ü���� 0

    public int Damage;
    public int HealPoint;

    void Awake()
    {
        nowHP = MaxHP;
        Initialize();
    }

    void Initialize() // Initialize()
    {
        RefreshU();
    }

    public void OnClickDamage() // ������
    {
        Damage = Random.Range(5, 26);
        nowHP -= Damage; // �������� �޴´�.
        if (nowHP < 0) // �׷��� 0���� �������� 0���� �����Ѵ�.
        {
            nowHP = 0;
        }

        Txt_text.text = $"�������� {Damage}��ŭ �޾ҽ��ϴ�";
        RefreshU();
    }

    public void OnClickHeal() // ȸ��
    {
        HealPoint = Random.Range(5, 21);
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }
        Txt_text.text = $"{HealPoint}��ŭ ȸ���߽��ϴ�";
        RefreshU();
    }

    void RefreshU() // RefreshUI
    {
        Img_HPbar.fillAmount = nowHP / MaxHP;
        Txt_HP.text = $"{nowHP} / {MaxHP}"; // 50 / 100
    }

}
