using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour
{

    // 変数の定義　（target という名前の箱を作る）
    public GameObject target;

    //  offset という名前の箱を作る
    // offset = transform.position - target.transform.position ;

    public Vector3 offset ;

    

    // Use this for initialization
    void Start()
    {

        // 箱の中にデータを入れる
      //  offset = transform.position - target.transform.position ;

    }

    // Update is called once per frame
    void Update()
    {


          transform.position = target.transform.position + offset;


        //  transform.position = target.transform.position ;

        Debug.Log(offset);

    }
}


