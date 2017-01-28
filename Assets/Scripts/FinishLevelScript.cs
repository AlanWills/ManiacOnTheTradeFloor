using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TransitionToSceneScript))]
[RequireComponent(typeof(BoxCollider2D))]
public class FinishLevelScript : MonoBehaviour
{
    public static float Player1Money = 0;
    public static float Player2Money = 0;

	// Use this for initialization
	void Start ()
    {
        
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Marker")
        {
            Player1Money = GameObject.Find("Players/Player1").GetComponent<StockManagementScript>().Money;
            Player2Money = GameObject.Find("Players/Player2").GetComponent<StockManagementScript>().Money;

            GetComponentInParent<TransitionToSceneScript>().ForceTransition();
        }
    }
}
