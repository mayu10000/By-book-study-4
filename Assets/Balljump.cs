using UnityEngine;
using System.Collections;

public class Balljump : MonoBehaviour
{

    //変数の定義　（データを入れる箱を作る）

    public float moveSpeed;
    private Rigidbody rb;
    public AudioClip coinGet;
    public AudioClip accelPoint;
    public AudioClip warpPoint;
    public AudioClip scalePoint;
    public float jumpSpeed;

    public bool isJumping = false;



    void Start()
    {
        //代入　（箱の中に右辺のデータを入れる）

        rb = GetComponent<Rigidbody>();

    }


    // Update is called once per frame

    void Update()
    {

        float moveH = Input.GetAxis("Horizontal");
        Debug.Log(moveH);
        float moveV = Input.GetAxis("Vertical");
        Debug.Log(moveV);
        Vector3 movement = new Vector3(moveH, 0, moveV);
        rb.AddForce(movement * moveSpeed);


        //   if (Input.GetButtonDown("Jump"))

        if (Input.GetButtonDown("Jump") && isJumping == false)




        {
            rb.velocity = Vector3.up * jumpSpeed;

            isJumping = true;

               }
          }

        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Floor"))
            {
                isJumping = false;
            }
        }
    }












