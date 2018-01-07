

using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{

    //変数の定義　（データを入れる箱を作る）

    public float moveSpeed;
    private Rigidbody rb;

    public AudioClip coinGet;


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

    }


            void OnTriggerEnter(Collider other){
            if (other.CompareTag("coin")){
                Destroy(other.gameObject);
                AudioSource.PlayClipAtPoint(coinGet, transform.position);
            }
        }

    }
            



