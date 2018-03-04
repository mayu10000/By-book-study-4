using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFromToController : MonoBehaviour
{
    public Transform m_startPoint;
    public Transform m_destinationPoint;
    public float m_speed = 10f;
    public float m_margin = 0.1f;
    bool isArrived = false;

    void Start()
    {
        transform.position = m_startPoint.position;
    }

    void Update()
    {
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
