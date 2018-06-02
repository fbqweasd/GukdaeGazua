using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtenInput : MonoBehaviour {

	public void TrainingButton()
    {
        SceneManager.LoadScene("Scenes/Training");
    }

    public void StoreButton()
    {
        SceneManager.LoadScene("Scenes/Store");
    }

    public void RestButton()
    {
        SceneManager.LoadScene("Scenes/Rest");
    }

    public void JobButton()
    {
        SceneManager.LoadScene("Scenes/Job");
    }

    public void ContestButton()
    {
        SceneManager.LoadScene("Scenes/Contest");
    }
}
