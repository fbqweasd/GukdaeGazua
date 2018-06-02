using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Result{
    GOLD,
    SILVER,
    BRONZE
}

public class NewBehaviourScript : MonoBehaviour {
    Result result;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OlympicOnClick(){

        switch(result){
            case Result.GOLD:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 1000000);
                break;
            case Result.SILVER:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 800000);
                break;
            case Result.BRONZE:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 500000);
                break;
        }

    }
    public void TeenagerOlympicOnClick(){
        switch (result)
        {
            case Result.GOLD:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 700000);
                break;
            case Result.SILVER:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 500000);
                break;
            case Result.BRONZE:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 300000);
                break;
        }
        
    }
    public void FriendshipOnClick(){
        switch (result)
        {
            case Result.GOLD:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 300000);
                break;
            case Result.SILVER:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 100000);
                break;
        }
        
    }
}
