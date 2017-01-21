using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockManagementScript : MonoBehaviour
{
    private const KeyCode buyKey = KeyCode.B;
    private const KeyCode sellKey = KeyCode.S; 
    private const float startingMoney = 1000;

    public float Money { get; private set; }
    public int Shares { get; private set; }

    public float CurrentSharePrice
    {
        get
        {
            // TODO
            return 1;
        }
    }


	// Use this for initialization
	void Start ()
    {
        Money = startingMoney;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(buyKey) || Input.GetKey(buyKey))
        {
            // If the user presses or is holding down the buy key, they attempt to buy a share
            if (Money >= CurrentSharePrice)
            {
                // The user has enough money to buy a share
                Shares++;
                Money -= CurrentSharePrice;
            }
        }
        else if (Input.GetKeyDown(sellKey) || Input.GetKey(sellKey))
        {
            // If the user presses or is holding down the sell key, they attempt to sell a share
            if (Shares > 0)
            {
                // The user has shares to sell, so we sell one for the current price
                Shares--;
                Money += CurrentSharePrice;
            }
        }
	}
}
