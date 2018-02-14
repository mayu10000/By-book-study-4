using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour
{

    // GmaeObjectを生成する数
    public int createNum = 200;

    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < createNum; i++)
        {
            // ゲームオブジェクトを生成
            var obj = GameObject.CreatePrimitive(PrimitiveType.Cube);

            // 接触判定を無効に
            obj.GetComponent<BoxCollider>().enabled = false;

            // R, G, Bをそれぞれランダムな値に設定する
            float rrand = Random.Range(0, 1.0f);
            float grand = Random.Range(0, 1.0f);
            float brand = Random.Range(0, 1.0f);
            obj.GetComponent<Renderer>().material.color = new Color(rrand, grand, brand, 1);

            // Rigidbodyをアタッチ
            Rigidbody rig = obj.AddComponent<Rigidbody>();

            // 親オブジェクトを設定
            obj.transform.SetParent(transform);

            // Local positionを設定
            obj.transform.localPosition = Vector3.zero;

            // 生成したGameObjectにランダムな力を加える
            float xrand = Random.Range(-5.0f, 5.0f);
            float yrand = Random.Range(-20.0f, 0);
            float zrand = Random.Range(-5.0f, 5.0f);
            rig.velocity = new Vector3(xrand, yrand, zrand);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}