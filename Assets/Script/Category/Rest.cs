﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rest : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void EatOnClick(){
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 60);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") - 7);
    }
    public void SleepOnClick(){
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 420);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") - 40);
    }
    public void EnergyDrinkOnClick(){
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 5);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") - 3);
    }
}
