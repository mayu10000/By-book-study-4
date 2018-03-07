using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nanamenikaatu4 : MonoBehaviour {

    Rigidbody myRigidbody;

    //前進するための力（追加）
    private float forwardForce = 200.0f;


    // *****　追加　回す
    private float turnForce = 500f;


    // Use this for initialization
    void Start () {

                myRigidbody = GetComponent<Rigidbody>();

            }
	
	// Update is called once per frame
	void Update () {


        // 速度ベクトルの方向にキャラクターを向ける。Y 軸方向は固定する。
        if (myRigidbody.velocity.sqrMagnitude > 0.3f)
        {
            transform.forward = new Vector3(myRigidbody.velocity.x, 0f, myRigidbody.velocity.z);
        }

        // 入力を検出し、入力に応じて力を加える
        float h = Input.GetAxis("Horizontal");
        float yVec = -1.0f;
        float zVec = -1.0f;

        // スペースを押した時にy軸に正の方向に力を加える
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // こちらの値は動きに合わせて調整してください
            yVec = 5;
        }

        this.myRigidbody.AddForce(h * turnForce * zVec, yVec * forwardForce, zVec * forwardForce);
    }
}








//  以下　変更前の分


//   this.myRigidbody.AddForce(new Vector3(0, -1.0f,  1.0f) * this.forwardForce);

//  float xVec = 0;
// float yVec = -1.0f;

// 左矢印を押している時にx軸に正の方向に力を加える
//   if (Input.GetKey(KeyCode.LeftArrow))
//    {
// こちらの値は動きに合わせて調整してください
//        xVec = 2;
//   }

// 左矢印を押している時にx軸に正の方向に力を加える
//   if (Input.GetKey(KeyCode.RightArrow))
//   {
// こちらの値は動きに合わせて調整してください
//        xVec = -2;
//    }

// スペースを押した時にy軸に正の方向に力を加える
//   if (Input.GetKeyDown(KeyCode.Space))
//   {
// こちらの値は動きに合わせて調整してください  *****
//  yVec = 5;
//        yVec = 100;

//   }

//   this.myRigidbody.AddForce(new Vector3(xVec, yVec, -1.0f) * this.forwardForce);

//      }
//   }






