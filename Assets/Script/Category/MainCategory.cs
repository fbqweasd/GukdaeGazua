using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCategory : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void TrainingOnClick(){
        // 메인 카테고리에서 훈련을 클릭했을때
        SceneManager.LoadScene("Scenes/Training");
    }
    public void RestOnClick(){
        // 메인 카테고리에서 휴식을 클릭했을때
        SceneManager.LoadScene("Scenes/Rest");
    }
    public void StoreOnClick(){
        // 메인 카테고리에서 상점을 클릭했을때
        SceneManager.LoadScene("Scenes/Store");
    }
    public void JobOnClick(){
        // 메인 카테고리에서 알바를 클릭했을때
        SceneManager.LoadScene("Scenes/Job");
    }
    public void ContestOnClick(){
        // 메인 카테고리에서 대회를 클릭했을때

        SceneManager.LoadScene("Scenes/Contest");
    }
}
