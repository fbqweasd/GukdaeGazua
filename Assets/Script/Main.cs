using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour {

    public Text UsernameText;
    public Text TimeText;

    // Use this for initialization
    void Start () {
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
