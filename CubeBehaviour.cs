using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeBehaviour : MonoBehaviour
{
    Vector3 Color;
    public List<GameObject> connected = new List<GameObject>();
    public Rigidbody rb; 
    public Vector3 initialSpeed = new Vector3(0.0f, 0.0f, 0.0f);
    public float distance = 5.0f;
    var thisRenderer = this.GetComponent<Renderer>();
    public list<var> connectedRenderer = new List<var>();
    
    void Start()
    {
        var cubeRenderer = this.GetComponent<Renderer>();
        
        foreach (Transform tchild in transform.parent)
        {
            GameObject child = tchild.gameObject;
            float dx = child.transform.position.x - this.transform.position.x;
            float dz = child.transform.position.z - this.transform.position.z;
           
            if (dx*dx + dz*dz == distance*distance)
            {
                connected.Add(child);
                connectedRenderer.Add(child.GetComponent<Renderer>);
            }
        }
        /*if ((130 > this.transform.position.x || this.transform.position.x > 150) && (250 > this.transform.position.x || this.transform.position.x > 270) && 90 < this.transform.position.z && this.transform.position.z < 110)
        {
            rb.mass = 100;
        }*/
        if (this.transform.position.x == 0)
        {
            Debug.Log("AA");
            Color customColor = new Color(0.4f, 0.9f, 0.7f, 1.0f);
            cubeRenderer.material.SetColor("_Color", customColor);
            //this.GetComponent<Material>().SetColor("_RED", new Color(1.0f, 0.0f, 0.0f, 1.0f)); 
        }
    }
    void FixedUpdate()
    {
        Vector3 dColor = new Vector3(0.0f, 0.0f, 0.0f);
        //float y = 0.0f;
        for (GameObject cube in connected)
        {
            //y += cube.transform.position.y - this.transform.position.y;
            for (int i = 0; i < 3; i++)
            {
            
            }
           
        }
        //Color = Color + dColor;
        //this.GetComponent<Renderer>().material.SetColor("_COLOR", new Color(Color[0], Color[1], Color[2], 1.0f));



        //rb.AddForce(1f*new Vector3(0.0f, y, 0.0f), ForceMode.Impulse);
    }
    
}
