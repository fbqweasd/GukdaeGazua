using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour {

    public GameObject OverlayPanel;
    public GameObject ModalPanel;

    public void EquipmentButtonOnClick(){
        if (PlayerPrefs.GetInt("money") - 70000 < 0)
        {
            OverlayPanel.gameObject.SetActive(true);
            ModalPanel.gameObject.SetActive(true);
        }
        else
        {
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 70000);
        }
    }

    public void FoodButtonOnClick(){
        if (PlayerPrefs.GetInt("money") - 30000 < 0)
        {
            OverlayPanel.gameObject.SetActive(true);
            ModalPanel.gameObject.SetActive(true);
        }
        else
        {
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 30000);
        }
    }

    public void OkButtonOnClick()
    {
        OverlayPanel.gameObject.SetActive(false);
        ModalPanel.gameObject.SetActive(false);
    }
}
