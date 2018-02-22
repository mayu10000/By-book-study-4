using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


//  public GameObject ;

public class
    skiercontroller3Unitychan3D : MonoBehaviour {

      Rigidbody2D rigid2D;

    // Rigidbody3D rigid3D;

      Animator animator　;


    

    float jumpForce = 680.0f;
    float runForce = 30.0f;
    float maxRunSpeed = 2.0f;
    float threshold = 0.2f;

    public bool isEnd { get; private set; }
    public object stateText { get; private set; }


    //ゲーム終了時に表示するテキスト（追加）
   //private GameObject stateText;
   // public GameObject stateText;


    //スコアを表示するテキスト（追加）
    private GameObject scoreText;
    //得点（追加）
    private int score = 0;



    // Use this for initialization
    void Start () {


        this.rigid2D = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update() {


        // ジャンプする  spaceキー

        if (Input.GetKeyDown(KeyCode.Space) &&
            this.rigid2D.velocity.y == 0)
        {
            this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * jumpForce);
        }



        // 左右移動
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;


        if (Input.acceleration.x > this.threshold) key = 1;
        if (Input.acceleration.x < -this.threshold) key = -1;

        // プレーヤーの速度
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);





        // スピード制限
        //    if (speedx < this.maxWalkSpeed)
        //    {
        //        this.rigid2D.AddForce(transform.right * key * this.walkForce);
        //    }



        // スピード制限
        if (speedx < this.maxRunSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.runForce);
        }



        // 動く方向に応じて反転
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

    }


        //トリガーモードで他のオブジェクトと接触した場合の処理
        void OnTriggerEnter(Collider other)
        {

            //障害物に衝突した場合
        //    if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag")
        //    {
        //        this.isEnd = true;
                //stateTextにGAME OVERを表示（追加）
       //         this.stateText.GetComponent<Text>().text = "GAME OVER";
       //     }


            //ゴール地点に到達した場合（追加）
            if (other.gameObject.tag == "GoalCusudama")
            {
                this.isEnd = true;


                //stateTextにGAME CLEARを表示（追加）
                this.stateText.GetComponent<Text>().text = "CLEAR!!";


            　　//restart　or　Quit


            }



            //コインに衝突した場合（追加）
            if (other.gameObject.tag == "CoinTag")
            {



                //パーティクルを再生（追加）
                GetComponent<ParticleSystem>().Play();

            }
}
}
