using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockManagementScript : MonoBehaviour
{
    private const float startingMoney = 1000;
    private AudioWaveScript wave;

    public float Money { get; private set; }
    public int Shares { get; private set; }

    private float CurrentSharePrice
    {
        get
        {
            return wave.GetCurrentAmplitudeMagnitude() * 1000;
        }
    }

	// Use this for initialization
	void Start ()
    {
        Money = startingMoney;
        wave = GameObject.Find("AudioWave").GetComponent<AudioWaveScript>();
	}

    public void BuyShare()
    {
        // If the user presses or is holding down the buy key, they attempt to buy a share
        if (Money >= CurrentSharePrice)
        {
            // The user has enough money to buy a share
            Shares++;
            Money -= CurrentSharePrice;
        }
    }

    public void SellShare()
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
