using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StoreButtonOnClick(){
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 60);
        PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 7530);
    }
    public void TutoringButtonOnClick(){
        
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 60);
        PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 10000);
    }
}
