using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverScene : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    public void Retry()
    {
        SceneManager.LoadScene("GameScreen");
    }
}
