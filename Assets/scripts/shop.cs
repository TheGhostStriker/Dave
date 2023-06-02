using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    private GameObject Canvas;
    private GameObject Money;
    public float money;
    public float FTEDictionary_price;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("HUD");
        Money = GameObject.Find("Money");
    }
    private void Update()
    {
     money = Money.GetComponent<Money_count>().MoneyNum;
    }

    // Update is called once per frame
    public void Buy_FTEDictionary()
    {
        if (money >= FTEDictionary_price)
        {
            Money.GetComponent<Money_count>().GainMoney(-FTEDictionary_price);
            Canvas.GetComponent<Stats>().buy_FTEDictionary();
                }
    }
}