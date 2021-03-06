﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement; //（追加）


//  public GameObject ;

public class skiercontroller2 : MonoBehaviour
{



    //Unityちゃんを移動させるコンポーネントを入れる（追加）
    private Rigidbody myRigidbody;

    //  Animator animator　;

        

    //前進するための力（追加）
    //private float forwardForce = 800.0f;





    //左右に移動するための力（追加）
   // private float turnForce = 500.0f;

   //*****
       private float turnForce = 800.0f;

    //ジャンプするための力（追加）
    //private float upForce = 500.0f;

    //*****
    private float upForce = 700.0f;


    //左右の移動できる範囲（追加）
    private float movableRange = 3.4f;


    //動きを減速させる係数（追加）
    private float coefficient = 0.95f;

    //ゲーム終了の判定（追加）
    private bool isEnd = false;

    //ゲーム終了時に表示するテキスト（追加）
    private GameObject stateText;


    //スコアを表示するテキスト（追加）
    private GameObject scoreText;
    //得点（追加）
    private int score = 0;



    //左ボタン押下の判定（追加）
    private bool isLButtonDown = false;
    //右ボタン押下の判定（追加）
    private bool isRButtonDown = false;


    //  追加　Quit　ボタンのため
    public GameObject menuObj;


    //  追加　ボタン　リフトに乗りますか？
      public GameObject liftObj;

    // Use this for initialization
    void Start()
    {



        //Rigidbodyコンポーネントを取得（追加）
        this.myRigidbody = GetComponent<Rigidbody>();


        //シーン中のstateTextオブジェクトを取得（追加）
        this.stateText = GameObject.Find("GameResultText");


        //シーン中のscoreTextオブジェクトを取得（追加）
        this.scoreText = GameObject.Find("ScoreText");



    }

    // Update is called once per frame
    void Update()
    {




        //Unityちゃんを矢印キーまたはボタンに応じて左右に移動させる（追加）
        if (Input.GetKey(KeyCode.LeftArrow) && -this.movableRange < this.transform.position.x)
        {
            //左に移動（追加）
            this.myRigidbody.AddForce(-this.turnForce, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && this.transform.position.x < this.movableRange)
        {
            //右に移動（追加）
            this.myRigidbody.AddForce(this.turnForce, 0, 0);

        }

        //Jumpステートの場合はJumpにfalseをセットする（追加）
        //   if (this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("Jump"))
        // {
        //     this.myAnimator.SetBool("Jump", false);
        // }

        //ジャンプしていない時にスペースが押されたらジャンプする（追加）
        if (Input.GetKeyDown(KeyCode.Space) && this.transform.position.y < 0.5f)
        {

            //ジャンプアニメを再生（追加）
            //   this.myAnimator.SetBool("Jump", true);

            //Unityちゃんに上方向の力を加える（追加）
            this.myRigidbody.AddForce(this.transform.up * this.upForce);

        }


    }


    //トリガーモードで他のオブジェクトと接触した場合の処理
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hi  hello");

        //障害物に衝突した場合
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag")
        {
            this.isEnd = true;
            //stateTextにGAME OVERを表示（追加）
            this.stateText.GetComponent<Text>().text = "GAME OVER";
        }
        Debug.Log("Hi  hello2");

        //ゴール地点に到達した場合（追加）
        if (other.gameObject.tag == "GoalKusudama")
        {
            this.isEnd = true;


            //stateTextにGAME CLEARを表示（追加）
            this.stateText.GetComponent<Text>().text = "Goal !!";


        }

        Debug.Log("Hi  hello3");

        //コインに衝突した場合（追加）
        //  if (other.gameObject.tag == "CoinTag")


        //こぶ　に衝突した場合（追加） ***
        if (other.gameObject.tag == "kobugetpoint")
        {


            //パーティクルを再生（追加）
           GetComponent<ParticleSystem>().Play();


            // スコアを加算(追加)
            this.score += 10;

            Debug.Log("Hi  hello4");


            //ScoreText獲得した点数を表示(追加)
            this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";



            //接触したコインのオブジェクトを破棄（追加）
            Destroy(other.gameObject);

        }

        //木　に衝突した場合（追加） ***
        if (other.gameObject.tag == "treelosepoint")
        {

            //パーティクルを再生（追加）
            GetComponent<ParticleSystem>().Play();


            // スコアを加算(追加)
            this.score -= 15;

            Debug.Log("Hi  hello5");


            //ScoreText獲得した点数を表示(追加)
            this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";



            //接触したコインのオブジェクトを破棄（追加）
            Destroy(other.gameObject);

        }

        // 追加　ボタン　Quit のため　ここから　

        if (other.gameObject.tag == "GoalKusudama")
        {
            menuObj.SetActive(true);

        }

    }

    // Quitボタンを押した時の処理
    public void Quit()
    {
        // ゲームを終了する
        Application.Quit();
    }

    // リスタートボタンを押した時の処理
    //public void Restart()


    public void Replay()
    {
        // ここで違うUIを表示する

        Debug.Log("リプレイする")　;

        //      liftObj.SetActive(true);

        //GameSceneを読み込む（追加）
       // SceneManager.LoadScene("GameScene");
        SceneManager.LoadScene("gerande 2");


    }

        // 使う関数はSetActiveです
        // GameObjectの変数.SetActive(true); で表示
        // GameObjectの変数.SetActive(false); で非表示

        //  if (other.gameObject.tag == "GoalKusudama")
        //  Replay  ボタン　が押されたら


        // リフトに乗る　ボタンを押すと
     public void liftButtonDown ()

   
    {



     //   MoveFromToControllersuzuki　を on にする



    }
         


        // ここまで

    }


                
                


            