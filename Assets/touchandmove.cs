using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchandmove : MonoBehaviour {



    Object = apple200



    // Use this for initialization
    void Start () {

                         
                       }


                    

    // Update is called once per frame
     void Update () {



    if (Input.GetMouseButtonDown(0))
    {
        Ray ray = new Ray();
        RaycastHit hit = new RaycastHit();
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //マウスクリックした場所からRayを飛ばし、オブジェクトがあればtrue 
        if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject == this.gameObject)
            {
                //ここにりんごをクリックした時の処理

                RaycastHit hit;
                Ray ray = camera.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    Transform objectHit = hit.transform;

                    // レイに当たったオブジェクトに何かをする



                }
            }
