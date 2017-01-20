using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanelUpdateScript : MonoBehaviour
{
    private Text currentMoneyText;
    private Text currentSharesText;
    private Text currentSharePriceText;

    private StockManagementScript stockManagementScript;

	// Use this for initialization
	void Start ()
    {
        currentMoneyText = GameObject.Find("CurrentMoneyText").GetComponent<Text>();
        currentSharesText = GameObject.Find("CurrentSharesText").GetComponent<Text>();
        currentSharePriceText = GameObject.Find("CurrentSharePriceText").GetComponent<Text>();

        stockManagementScript = GameObject.Find("Player").GetComponent<StockManagementScript>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentMoneyText.text = stockManagementScript.Money.ToString();
        currentSharesText.text = stockManagementScript.Shares.ToString();
        currentSharePriceText.text = stockManagementScript.CurrentSharePrice.ToString();
	}
}
