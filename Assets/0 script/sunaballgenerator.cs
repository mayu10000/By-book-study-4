using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class sunaballgenerator : MonoBehaviour {

    // public GameObject applePrefab;

    public GameObject redballPrefab;

    public GameObject bombPrefab;
    float span = 1.0f;
    float delta = 0;

    int ratio = 2;

    float speed = -0.03f;

    public void SetParameter(float span, float speed, int ratio)
    {
        this.span = span;
        this.speed = speed;
        this.ratio = ratio;
    }





    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


       // this.delta += Time.deltaTime;

        this.delta += Time.deltaTime / 10 ;

        if (this.delta > this.span)
        {
            this.delta = 0;


            //   GameObject item = Instantiate(applePrefab) as GameObject;


            GameObject item;
            int dice = Random.Range(1, 11);
            if (dice <= this.ratio)
            {
                item = Instantiate(bombPrefab) as GameObject;
            }
            else
            {
             //   item = Instantiate(applePrefab) as GameObject;
                
                item = Instantiate(redballPrefab) as GameObject;
            }

            redballPrefab.transform.position = new　Vector3(-5315, 2, 476) ;



            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);

            item.transform.position = new Vector3(x, 4, z);


          //  item.GetComponent<ItemController>().dropSpeed = this.speed;

            item.GetComponent<sunaitemcontroller>().dropSpeed = this.speed;

            
        }

    }
}

internal class ItemController
{
}