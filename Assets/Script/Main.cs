using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Timers;

public class Main : MonoBehaviour {

    public GameObject OverlayPanel;
    public GameObject EndFootballModalPanel;
    public GameObject EndBaseballModalPanel;
    public GameObject EndBasketballModalPanel;
    public GameObject EndWreslingModalPanel;
    public GameObject EndFailModalPanel;
    public Text FatigueText;
    public Text HealthText;
    public Text FlexibilityText;
    public Text PowerText;
    public Text EnduranceText;
    public Text MoneyText;
    public Text UsernameText;
    public Text TimeText;
    public Timer timer;

    // Use this for initialization
    void Start () {
        UsernameText.text = PlayerPrefs.GetString("username");
        TimeText.text = PlayerPrefs.GetInt("time") + "분";

        FatigueText.text = PlayerPrefs.GetInt("fatigue").ToString();
        HealthText.text = PlayerPrefs.GetInt("health").ToString();
        FlexibilityText.text = PlayerPrefs.GetInt("flexibility").ToString();
        PowerText.text = PlayerPrefs.GetInt("power").ToString();
        EnduranceText.text = PlayerPrefs.GetInt("endurance").ToString();
        MoneyText.text = PlayerPrefs.GetInt("money").ToString();
	}

    public void OkButtonOnClick()
    {
        OverlayPanel.gameObject.SetActive(false);
        EndFootballModalPanel.gameObject.SetActive(false);
        EndBaseballModalPanel.gameObject.SetActive(false);
        EndBasketballModalPanel.gameObject.SetActive(false);
        EndWreslingModalPanel.gameObject.SetActive(false);
        EndFailModalPanel.gameObject.SetActive(false);
        SceneManager.LoadScene("Scenes/Menu");
    }

    // Update is called once per frame
    void Update () {
        if (PlayerPrefs.GetInt("time") <= 0)
        {
            OverlayPanel.gameObject.SetActive(true);
            EndFootballModalPanel.gameObject.SetActive(true);
            return;
        }
        if (PlayerPrefs.GetInt("fatigue") <= 0)
        {
            FatigueText.text = "0";
        }
        TimeText.text = PlayerPrefs.GetInt("time") + "분";
        FatigueText.text = PlayerPrefs.GetInt("fatigue").ToString();
        HealthText.text = PlayerPrefs.GetInt("health").ToString();
        FlexibilityText.text = PlayerPrefs.GetInt("flexibility").ToString();
        PowerText.text = PlayerPrefs.GetInt("power").ToString();
        EnduranceText.text = PlayerPrefs.GetInt("endurance").ToString();
        MoneyText.text = PlayerPrefs.GetInt("money").ToString();
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
