﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscKeyEventMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/Menu");
            }
        }
    }
}
