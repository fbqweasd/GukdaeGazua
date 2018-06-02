using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void PushUpOnClick(){
        PlayerPrefs.SetInt("time",PlayerPrefs.GetInt("time") - 10);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue")+3);
        PlayerPrefs.SetInt("health", PlayerPrefs.GetInt("health") + 4);
        PlayerPrefs.SetInt("flexibility", PlayerPrefs.GetInt("flexibility") + 4);
        PlayerPrefs.SetInt("power", PlayerPrefs.GetInt("power") + 5);
        PlayerPrefs.SetInt("endurance", PlayerPrefs.GetInt("endurance") + 4);
    }

    public void SitUpOnClick(){
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 10);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 3);
        PlayerPrefs.SetInt("health", PlayerPrefs.GetInt("health") + 4);
        PlayerPrefs.SetInt("flexibility", PlayerPrefs.GetInt("flexibility") + 5);
        PlayerPrefs.SetInt("power", PlayerPrefs.GetInt("power") + 3);
        PlayerPrefs.SetInt("endurance", PlayerPrefs.GetInt("endurance") + 5);
    }
    public void JumplopeOnClick(){
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 30);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 5);
        PlayerPrefs.SetInt("health", PlayerPrefs.GetInt("health") + 7);
        PlayerPrefs.SetInt("flexibility", PlayerPrefs.GetInt("flexibility") + 3);
        PlayerPrefs.SetInt("power", PlayerPrefs.GetInt("power") + 2);
        PlayerPrefs.SetInt("endurance", PlayerPrefs.GetInt("endurance") + 6);
    }
    public void RunOnClick(){
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 60);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 9);
        PlayerPrefs.SetInt("health", PlayerPrefs.GetInt("health") + 7);
        PlayerPrefs.SetInt("flexibility", PlayerPrefs.GetInt("flexibility") + 1);
        PlayerPrefs.SetInt("power", PlayerPrefs.GetInt("power") + 1);
        PlayerPrefs.SetInt("endurance", PlayerPrefs.GetInt("endurance") + 7);
    }
    public void TaekkyonOnClick(){
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 60);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 10);
        PlayerPrefs.SetInt("health", PlayerPrefs.GetInt("health") + 2);
        PlayerPrefs.SetInt("flexibility", PlayerPrefs.GetInt("flexibility") + 10);
        PlayerPrefs.SetInt("power", PlayerPrefs.GetInt("power") + 1);
        PlayerPrefs.SetInt("endurance", PlayerPrefs.GetInt("endurance") + 1);
    }

}
