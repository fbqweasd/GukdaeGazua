﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void EquipmentOnClick(){
        PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 70000);
    }
    public void FoodOnClick(){
        PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 30000);
    }
}