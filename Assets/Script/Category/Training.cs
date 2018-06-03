using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour {
    public GameObject OverlayPanel;
    public GameObject FatigueModalPanel;

   public void PushUpButtonOnClick(){
        if (PlayerPrefs.GetInt("fatigue") + 10 > PlayerPrefs.GetInt("health"))
        {
            OverlayPanel.gameObject.SetActive(true);
            FatigueModalPanel.gameObject.SetActive(true);
            return;
        }

        PlayerPrefs.SetInt("time",PlayerPrefs.GetInt("time") - 30);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue")+10);
        PlayerPrefs.SetInt("health", PlayerPrefs.GetInt("health") + 7);
        PlayerPrefs.SetInt("flexibility", PlayerPrefs.GetInt("flexibility") + 4);
        PlayerPrefs.SetInt("power", PlayerPrefs.GetInt("power") + 5);
        PlayerPrefs.SetInt("endurance", PlayerPrefs.GetInt("endurance") + 4);
    }

    public void SitUpButtonOnClick(){
        if (PlayerPrefs.GetInt("fatigue") + 10 > PlayerPrefs.GetInt("health"))
        {
            OverlayPanel.gameObject.SetActive(true);
            FatigueModalPanel.gameObject.SetActive(true);
            return;
        }

        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 30);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 10);
        PlayerPrefs.SetInt("health", PlayerPrefs.GetInt("health") + 7);
        PlayerPrefs.SetInt("flexibility", PlayerPrefs.GetInt("flexibility") + 5);
        PlayerPrefs.SetInt("power", PlayerPrefs.GetInt("power") + 3);
        PlayerPrefs.SetInt("endurance", PlayerPrefs.GetInt("endurance") + 5);
    }
    public void JumpRopeButtonOnClick(){
        if (PlayerPrefs.GetInt("fatigue") + 20 > PlayerPrefs.GetInt("health"))
        {
            OverlayPanel.gameObject.SetActive(true);
            FatigueModalPanel.gameObject.SetActive(true);
            return;
        }

        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 60);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 20);
        PlayerPrefs.SetInt("health", PlayerPrefs.GetInt("health") + 10);
        PlayerPrefs.SetInt("flexibility", PlayerPrefs.GetInt("flexibility") + 3);
        PlayerPrefs.SetInt("power", PlayerPrefs.GetInt("power") + 2);
        PlayerPrefs.SetInt("endurance", PlayerPrefs.GetInt("endurance") + 6);
    }
    public void RunButtonOnClick(){
        if (PlayerPrefs.GetInt("fatigue") + 30 > PlayerPrefs.GetInt("health"))
        {
            OverlayPanel.gameObject.SetActive(true);
            FatigueModalPanel.gameObject.SetActive(true);
            return;
        }

        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 90);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 30);
        PlayerPrefs.SetInt("health", PlayerPrefs.GetInt("health") + 15);
        PlayerPrefs.SetInt("flexibility", PlayerPrefs.GetInt("flexibility") + 1);
        PlayerPrefs.SetInt("power", PlayerPrefs.GetInt("power") + 2);
        PlayerPrefs.SetInt("endurance", PlayerPrefs.GetInt("endurance") + 10);
    }
    public void TaekkyonButtonOnClick(){
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 90);
        PlayerPrefs.SetInt("fatigue", PlayerPrefs.GetInt("fatigue") + 40);
        PlayerPrefs.SetInt("health", PlayerPrefs.GetInt("health") + 5);
        PlayerPrefs.SetInt("flexibility", PlayerPrefs.GetInt("flexibility") + 12);
        PlayerPrefs.SetInt("power", PlayerPrefs.GetInt("power") + 3);
        PlayerPrefs.SetInt("endurance", PlayerPrefs.GetInt("endurance") + 1);
    }

    public void TimeOver()
    {
        OverlayPanel.gameObject.SetActive(true);
        FatigueModalPanel.gameObject.SetActive(true);
    }

    public void OkButtonOnClick()
    {
        OverlayPanel.gameObject.SetActive(false);
        FatigueModalPanel.gameObject.SetActive(false);
    }
}
