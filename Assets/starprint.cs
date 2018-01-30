using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starprint : MonoBehaviour {

	// Use this for initialization
	void Start () {


        string str;
        str = " " ;

for (int i = 0; i < 4; i++)
        {
            str += "*";
            Debug.Log(str);
        }


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
