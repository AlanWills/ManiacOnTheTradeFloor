using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionToSceneScript : MonoBehaviour
{
    public SceneAsset SceneToTransitionTo;
    public float TimeToWait;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Time.timeSinceLevelLoad > TimeToWait)
        {
            SceneManager.LoadScene(SceneToTransitionTo.name);
        }
	}
}
