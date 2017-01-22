using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLoadingSceneScript : MonoBehaviour {

    public string SceneToLoad;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetScene()
    {
        LoadingScript.SceneToLoad = SceneToLoad;
    }
}
