using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeBehaviour : MonoBehaviour
{
    Color Color;
    public List<GameObject> connected = new List<GameObject>();
    public Rigidbody rb; 
    public Vector3 initialSpeed = new Vector3(0.0f, 0.0f, 0.0f);
    public float distance = 5.0f;
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        foreach (Transform tchild in transform.parent)
        {
            GameObject child = tchild.gameObject;
            float dx = child.transform.position.x - this.transform.position.x;
           
            if (dx*dx == distance*distance)
            {
                connected.Add(child);
            }
        }
        if (connected.Count == 1)
        {
            rb.mass = 1000000000;
        }
    }
    void FixedUpdate()
    {
        float y = 0.0f;
        float z = 0.0f;

        foreach (GameObject cube in connected)
        {
            if (cube.transform.position.x <= 180){
            y += cube.transform.position.y - this.transform.position.y;
            z += cube.transform.position.z - this.transform.position.z;}
            else{y += cube.transform.position.y - this.transform.position.y;}
        }

        rb.AddForce(1f*new Vector3(0.0f, y, z), ForceMode.Impulse);
    }
}
