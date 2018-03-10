using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timesetting : MonoBehaviour {


    // 何秒おきに生成するか秒数
    public float timeOut;

    private float timeElapsed;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        // 経過時間を足していく
        timeElapsed += Time.deltaTime;

        // 時間が経過したかチェック
        if (timeElapsed >= timeOut)
        {

            // ここでオブジェクトの生成を行う

            timeElapsed = 0.0f;
        }



    }
}
