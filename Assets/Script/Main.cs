using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Timers;

public class Main : MonoBehaviour {

    private void Timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 1);
    }


    public Text UsernameText;
    public Text TimeText;
    public Timer timer;

    // Use this for initialization
    void Start () {

        timer = new System.Timers.Timer(1000);
        timer.Elapsed += Timer_Elapsed;
        timer.Enabled = true;
        UsernameText.text = PlayerPrefs.GetString("username");
        TimeText.text = PlayerPrefs.GetInt("time") + "분";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TrainingButtonOnClick()
    {
        SceneManager.LoadScene("Scenes/Training");
    }

    public void RestButtonOnClick()
    {
        SceneManager.LoadScene("Scenes/Rest");
    }

    public void ContestButtonOnClick()
    {
        SceneManager.LoadScene("Scenes/Contest");
    }

    public void StoreButtonOnClick()
    {
        SceneManager.LoadScene("Scenes/Store");
    }

    public void JobButtonOnClick()
    {
        SceneManager.LoadScene("Scenes/Job");
    }
}
