using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rest : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void EatClick(){
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 60);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") - 7);
    }
    void SleepClick(){
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 420);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") - 40);
    }
    void EnergyDrinkClick(){
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 5);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") - 3);
    }
}
