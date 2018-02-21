using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  public GameObject ;

public class skiercontroller : MonoBehaviour {

      Rigidbody2D rigid2D;
    // Rigidbody3D rigid3D;

  

    Animator animator　;


    

    float jumpForce = 680.0f;
    float runForce = 30.0f;
    float maxRunSpeed = 2.0f;
    float threshold = 0.2f;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


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
}
