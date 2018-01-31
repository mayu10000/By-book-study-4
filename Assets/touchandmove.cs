using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchandmove : MonoBehaviour {

    GameObject apple200;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
            {
                // ここに衝突したGameObjectの名前がDebugLogに表示されます。
                // このifの中で当たったゲームオブジェクトを判定して処理を行ってください
                Debug.Log(hit.collider.gameObject.name);
            }
        }
    }
}



