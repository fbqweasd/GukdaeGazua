using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject OverlayPanel;
    public GameObject ModalPanel;
    public InputField UsernameInputField;

    public void PlayButtonOnCilck()
    {
        Debug.Log("Play Button Click");
        PlayerPrefs.DeleteAll();
        OverlayPanel.gameObject.SetActive(true);
        ModalPanel.gameObject.SetActive(true);
        UsernameInputField.Select();
    }

    public void OkButtonOnClick()
    {
        OverlayPanel.gameObject.SetActive(false);
        ModalPanel.gameObject.SetActive(false);

        // PlayerPrefs 세팅
        PlayerPrefs.SetString("username", UsernameInputField.text);
        PlayerPrefs.SetInt("time", 7884000);
        PlayerPrefs.SetInt("fatigue", 0);
        PlayerPrefs.SetInt("health", 40);
        PlayerPrefs.SetInt("flexibility", 5);
        PlayerPrefs.SetInt("power", 10);
        PlayerPrefs.SetInt("endurance", 5);

        Debug.Log(PlayerPrefs.GetString("username"));

        SceneManager.LoadScene("Scenes/Main");
    }

    public void CancelButtonOnClick()
    {
        OverlayPanel.gameObject.SetActive(false);
        ModalPanel.gameObject.SetActive(false);
    }

    public void ContinueButtonOnCilck()
    {
        Debug.Log("Continue Button Click");
    }

    public void ViewButtonOnCilck()
    {
        Debug.Log("View Button Click");
    }
}
