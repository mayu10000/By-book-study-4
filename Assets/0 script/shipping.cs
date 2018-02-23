using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cooking : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }






    //トリガーモードで他のオブジェクトと接触した場合の処理
    void OnTriggerEnter(Collider other)
    {


        //コインに衝突した場合（追加）
        if (other.gameObject.tag == "CoinTag")
        {



            //パーティクルを再生（追加）
            GetComponent<ParticleSystem>().Play();





            // スコアを加算(追加)
            //           this.score += 10;

            //ScoreText獲得した点数を表示(追加)
            //         this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";



        }
    }
}

