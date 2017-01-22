using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour
{
    public static string SceneToLoad;

	// Use this for initialization
	void Start ()
    {
        SceneManager.LoadSceneAsync(SceneToLoad);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
