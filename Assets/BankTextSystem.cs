using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BankTextSystem : MonoBehaviour
{
    public Text BankText;

    public int Money;

    void Start()
    {
        Money = BankSystemSetScript.BankMoney;
        Debug.Log(Money);
    }

    // Update is called once per frame
    void Update()
    {
        Money = BankSystemSetScript.BankMoney;
        Debug.Log(Money + "Won");

        BankText.text = Money.ToString();
    }
}
