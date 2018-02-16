using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nanamenikaatu : MonoBehaviour {

  //  public class Test : MonoBehaviour
  //  {

        Rigidbody myRigidbody;

        //前進するための力（追加）
        private float forwardForce = 800.0f;

        // Use this for initialization
        void Start()
        {
            myRigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
         //   this.myRigidbody.AddForce(new Vector3(0, -1.0f,  1.0f) * this.forwardForce);

              this.myRigidbody.AddForce(new Vector3(0, -1.0f, -1.0f) * this.forwardForce);


    }
    }



    // Use this for initialization
   // void Start () {
		
//	}
	
	// Update is called once per frame
 //	void Update () {
		
//	}
// }
