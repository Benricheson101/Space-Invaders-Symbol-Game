﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class NewBehaviourScript : MonoBehaviour {

    public void LoadScene(string SceneToLoad)
    {
        SceneManager.LoadScene(SceneToLoad);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}

	
	
