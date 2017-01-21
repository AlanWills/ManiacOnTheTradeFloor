using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionToSceneScript : MonoBehaviour
{
    public SceneAsset SceneToTransitionTo;

    // Use negative time for indefinite wait
    public float TimeToWait;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (TimeToWait >= 0 && Time.timeSinceLevelLoad > TimeToWait)
        {
            ForceTransition();
        }
	}

    public void ForceTransition()
    {
        SceneManager.LoadScene(SceneToTransitionTo.name);
    }
}
