using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; // LoadScene を使うために必要！！




public class ToGerandeScenedirector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //クリックされたら・・・・scene を遷移する
        //  ***** ここを　UI　ボタンに変更する
        if (Input.GetMouseButtonDown(0))



        {
           // SceneManager.LoadScene("GameScene");
            SceneManager.LoadScene("gerande 2");

        }
    }
}


	

