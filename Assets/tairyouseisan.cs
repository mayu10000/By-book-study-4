using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class tairyouseisan : MonoBehaviour
{

    // Use this for initialization


    // 作成するプレハブ(インスペクタから設定）
    public GameObject prefab;





    //作成する数(インスペクタから設定)　
    public int createNum;

    void Start () {

        for (int i = 0; i < createNum; i++)
        {
            //生成
            Instantiate(prefab);
        }


        //  transform.positionをDebug.Log
        Debug.Log(transform.position) ;

        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

