using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void PlayButtonOnCilck() {
        Debug.Log("Play Button Click");
        SceneManager.LoadScene("Scenes/Main");
        PlayerPrefs.DeleteAll();
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
