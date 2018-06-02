using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Script : MonoBehaviour {

    public void Start_Bt_cilck() {
        Debug.Log("Start_Bt_cilck");
        SceneManager.LoadScene("Scene/Play_Form");
    }

    public void reStart_Bt_cilck()
    {
        Debug.Log("reStart");
    }

    public void view_player_Bt_cilck()
    {
        Debug.Log("view_player");
    }

    public void Exit_Bt()
    {
        SceneManager.LoadScene("Scene/main_Form");
        //Application.Quit();
    }
}
