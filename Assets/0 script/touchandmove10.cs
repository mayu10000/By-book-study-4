using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchandmove10 : MonoBehaviour
{

    GameObject apple200;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.collider.gameObject.name);

                // tagを判定しているのは操作するGameObjectを制限する為です
                if (apple200 == null && hit.collider.gameObject.tag == "apple200")
                {
                    apple200 = hit.collider.gameObject;
                }
                else
                {
                    apple200.transform.position = hit.collider.transform.position;
                    apple200 = null;
                }
            }
        }
    }
}