using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockingAudioScript : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void PlayAudio()
    {
        AudioSource audioToPlay = GetComponentInParent<AudioSource>();
        audioToPlay.Play();

        TransitionToSceneScript transition = GetComponentInParent<TransitionToSceneScript>();
        transition.Reset(audioToPlay.clip.length);
    }
}
