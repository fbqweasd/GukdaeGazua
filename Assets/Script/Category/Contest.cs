using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Result{
    GOLD,
    SILVER,
    BRONZE
}

public class Contest : MonoBehaviour {
    Result result = Result.SILVER;

    public void OlympicButtonOnClick(){
        switch(result){
            case Result.GOLD:
                PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 200);
                PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 100000);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 100000);
                break;
            case Result.SILVER:
                PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 200);
                PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 100000);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 80000);
                break;
            case Result.BRONZE:
                PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 200);
                PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 100000);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 50000);
                break;
        }

    }
    public void TeenagerOlympicButtonOnClick(){
        switch (result)
        {
            case Result.GOLD:
                PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 160);
                PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 80000);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 70000);
                break;
            case Result.SILVER:
                PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 160);
                PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 80000);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 50000);
                break;
            case Result.BRONZE:
                PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 160);
                PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 80000);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 30000);
                break;
        }
        
    }
    public void FriendshipButtonOnClick(){
        switch (result)
        {
            case Result.GOLD:
                PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 130);
                PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 70000);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 30000);
                break;
            case Result.SILVER:
                PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 130);
                PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 70000);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 20000);
                break;
        }
        
    }
}
