using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ugoku : MonoBehaviour
{
    public float nowPosi;
    public float time = 2;
    public float haba = 1.2f;
    public float offset;
    void Start()
    {
        nowPosi = this.transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x, nowPosi + Mathf.PingPong(Time.time/time + offset, haba));
    }
}
