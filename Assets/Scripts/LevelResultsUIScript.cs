using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelResultsUIScript : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        float player1Score = FinishLevelScript.Player1Money;
        float player2Score = FinishLevelScript.Player2Money;

        GameObject.Find("Player1UI/MoneyText").GetComponent<Text>().text = player1Score.ToString();
        GameObject.Find("Player2UI/MoneyText").GetComponent<Text>().text = player2Score.ToString();

        GameObject resultUI = GameObject.Find("ResultUI");

        if (player1Score == player2Score)
        {
            resultUI.GetComponentInChildren<Text>().text = "DRAW!!";
            GameObject.Find("Cup").SetActive(false);
        }
        else
        {
            if (player2Score > player1Score)
            {
                resultUI.transform.Rotate(new Vector3(0, 0, 1), 180);
            }

            resultUI.transform.Translate(new Vector3(0, -100, 0));
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
