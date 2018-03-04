using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delayed : MonoBehaviour
{
    public float m_delayTime = 8f;
    public GameObject m_gameObject;
    float m_timer;

    void Start()
    {
        m_gameObject.SetActive(false);
    }

    void Update()
    {
        if (!m_gameObject.activeSelf)
        {
            if (m_timer < m_delayTime)
            {
                m_timer += Time.deltaTime;
            }
            else
            {
                m_gameObject.SetActive(true);
            }
        }
    }
}
