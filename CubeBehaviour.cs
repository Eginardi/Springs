using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public List<GameObject> connected = new List<GameObject>();
    public Rigidbody rb; 
    public Vector3 initialSpeed = new Vector3(0.0f, 0.0f, 0.0f);
    public Transform parent;
    public float distance = 10.0f;

    void Start()
    {
        Debug.Log("I'm born!");
        parent = transform.parent;
        rb.AddForce(initialSpeed);
        foreach (Transform tchild in parent.parent.transform)
        {

            GameObject child = tchild.transform.Find("Cube").gameObject;
            if ((child.transform.position.x - this.transform.position.x)*(child.transform.position.x - this.transform.position.x) + (child.transform.position.z - this.transform.position.z)*(child.transform.position.z - this.transform.position.z) == distance*distance)
            {
                connected.Add(child);
            }
        Debug.Log("I'm even born successfully");
        }
    }
    void FixedUpdate()
    {
        //rb.AddForce(-new Vector3(0.0f, this.transform.position.y, 0.0f));
        foreach (GameObject cube in connected)
        {
            Debug.Log(Time.fixedDeltaTime);
            rb.AddForce(1f*new Vector3(0.0f, cube.transform.position.y - this.transform.position.y, 0.0f), ForceMode.Impulse);
        }
    }
}