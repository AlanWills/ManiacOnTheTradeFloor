using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIUpdateScript : MonoBehaviour
{
    private Text currentMoneyText;
    private Text currentSharesText;

    public StockManagementScript StockManagementScript;

	// Use this for initialization
	void Start ()
    {
        currentMoneyText = transform.Find("Text/MoneyText/CurrentMoneyText").gameObject.GetComponent<Text>();
        currentSharesText = transform.FindChild("Text/SharesText/CurrentSharesText").gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentMoneyText.text = StockManagementScript.Money.ToString();
        currentSharesText.text = StockManagementScript.Shares.ToString();
	}
}
