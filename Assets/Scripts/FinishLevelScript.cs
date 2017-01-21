using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(TransitionToSceneScript))]
public class FinishLevelScript : MonoBehaviour
{
    public static float Player1Money = 0;
    public static float Player2Money = 0;

    private AudioSource audioSource;

	// Use this for initialization
	void Start ()
    {
        audioSource = GetComponentInParent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Make sure we have had at least enough time to play the song
		if (!audioSource.isPlaying && Time.timeSinceLevelLoad > audioSource.clip.length)
        {
            GetComponentInParent<TransitionToSceneScript>().ForceTransition();

            Player1Money = GameObject.Find("Players/Player1").GetComponent<StockManagementScript>().Money;
            Player2Money = GameObject.Find("Players/Player2").GetComponent<StockManagementScript>().Money;
        }
	}
}
