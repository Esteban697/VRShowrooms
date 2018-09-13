using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating2 : MonoBehaviour
{ 
    public float amplitude;          //Set in Inspector 
    public float speed;                  //Set in Inspector 
    private float tempVal, tempVal2;
    private Vector3 tempPos;
    void Start()
    {
        tempPos = transform.position;
        tempVal = transform.position.y;
        tempVal2 = transform.position.x;
    }
    void Update()
    {
        tempPos.y = tempVal + amplitude * Mathf.Sin(speed * Time.time);
        tempPos.x = tempVal2 + amplitude * Mathf.Sin(1.8f * speed * Time.time);
        transform.position = tempPos;
    }
}