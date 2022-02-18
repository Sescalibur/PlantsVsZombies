using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    private int TotalMoney = 200;
    private Text moneyText;
    public enum MoneyControl
    {
        successful, unsuccessful
    }
    private void Start()
    {
        GetComponent<Text>().text = TotalMoney.ToString();
        moneyText = GetComponent<Text>();
    }
    public void cashsUp(int cash)
    {
        TotalMoney += cash;
        ScreenMoney();
    }

    public MoneyControl CashUse(int cash)
    {
        if (TotalMoney >= cash)
        {
            TotalMoney -= cash;
            ScreenMoney();
            return MoneyControl.successful;
        }
        else
        {
            return MoneyControl.unsuccessful;
        }
    }

    public void ScreenMoney()
    {
        moneyText.text = TotalMoney.ToString();
    }

}
