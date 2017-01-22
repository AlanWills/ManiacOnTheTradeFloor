using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionToSceneScript : MonoBehaviour
{
    public string SceneToTransitionTo;

    // Use negative time for indefinite wait
    public float TimeToWait = -1;

    private float timer = 0;

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;

        if (TimeToWait >= 0 && timer > TimeToWait)
        {
            ForceTransition();
        }
	}

    public void Reset(float timeToWait)
    {
        TimeToWait = timeToWait;
        timer = 0;
    }

    public void ForceTransition()
    {
        SceneManager.LoadScene(SceneToTransitionTo);
    }
}
