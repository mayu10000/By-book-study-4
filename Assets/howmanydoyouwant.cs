using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howmanydoyouwant : MonoBehaviour
{


    // 作成するプレハブ(インスペクタから設定）
    public GameObject prefab;

    // GameObjectobject =　apple5 ;


    //作成する数(インスペクタから設定)　
    public int createNum;



    void aaa()
    {

        for (int i = 0; i < createNum; i++)
        {
            //生成
            GameObject instance = Instantiate(prefab);
            //生成したオブジェクトの位置をずらす
            // instance.transform.position = gameObject.position + 2



            instance.transform.position =
              instance.transform.position + Vector3.right * 2 * i;


        }

        //  transform.positionをDebug.Log
        Debug.Log(transform.position);


    }

    // Use this for initialization
    private void Start()
    {

        // aaaa() の中に入れた処理は多分 Start() で呼び出したいのだろうからここから呼び出しておく
        aaa();

    }





    // Update is called once per frame
    void Update()
    {

    }

}
