using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nanamenikaatu2 : MonoBehaviour {

    Rigidbody myRigidbody;

    //前進するための力（追加）
    private float forwardForce = 200.0f;



    // Use this for initialization
    void Start () {

                myRigidbody = GetComponent<Rigidbody>();

            }
	
	// Update is called once per frame
	void Update () {


        //   this.myRigidbody.AddForce(new Vector3(0, -1.0f,  1.0f) * this.forwardForce);

        float xVec = 0;
        float yVec = -1.0f;

        // 左矢印を押している時にx軸に正の方向に力を加える
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // こちらの値は動きに合わせて調整してください
            xVec = 2;
        }

        // 左矢印を押している時にx軸に正の方向に力を加える
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // こちらの値は動きに合わせて調整してください
            xVec = -2;
        }

        // スペースを押した時にy軸に正の方向に力を加える
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // こちらの値は動きに合わせて調整してください
            yVec = 5;
        }

        this.myRigidbody.AddForce(new Vector3(xVec, yVec, -1.0f) * this.forwardForce);

    }
}



		
	

