using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class PaSysHaikiEn  : MonoBehaviour {


    public float engineRevs;
    public float exhaustRate;

    ParticleSystem exhaust;


    // Use this for initialization
    void Start () {


        exhaust = GetComponent & lt; ParticleSystem & gt; ();


    }
	
	// Update is called once per frame
	void Update () {


        exhaust.emissionRate = engineRevs * exhaustRate;


    }
}


// JS

var engineRevs: float;
    var exhaustRate: float;

    var exhaust: ParticleSystem;


    function Start()
{
    exhaust = GetComponent.& lt; ParticleSystem & gt; ();
}


function Update()
{
    exhaust.emissionRate = engineRevs * exhaustRate;
}