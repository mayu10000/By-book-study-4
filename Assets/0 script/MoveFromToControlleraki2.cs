using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFromToControlleraki2 : MonoBehaviour {


    public Transform m_startPoint;
    public Transform m_destinationPoint;
    public Vector3 m_startPosition;
    public float m_speed = 10f;
    public float m_margin = 0.1f;
    bool isArrived = false;

    public void Reset()
    {
        transform.position = m_startPosition;
        isArrived = false;
    }




    // Use this for initialization
    void Start () {

        m_startPosition = m_startPoint.position;
        transform.position = m_startPosition;

            }
	
	// Update is called once per frame
	void Update () {


        if (isArrived) return;

        if (Vector3.Distance(transform.position, m_destinationPoint.position) > m_margin)
        {
            Vector3 direction = m_destinationPoint.position - transform.position;
            transform.position = transform.position + direction.normalized * m_speed * Time.deltaTime;
        }
        else
        {
            isArrived = true;
        }



    }
}
