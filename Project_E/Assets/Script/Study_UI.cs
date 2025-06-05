using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Study_UI : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public string NextText;

    public void OnClickbutton()
    {
        Text.text = NextText;
    }
}
