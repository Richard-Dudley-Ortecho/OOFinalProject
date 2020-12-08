using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFan : MonoBehaviour
{
    public GameObject bladeObject;
    public Transform parentObject;
    public GameObject[] blades;
    public float degreesPerSecond = 200f;
    public int numBlades = 5;



    // Start is called before the first frame update
    void Start()
    {
        blades = new GameObject[numBlades];
        int i;
        for (i = 0; i < numBlades; i++){
            blades[i] = Instantiate(bladeObject, new Vector3(0,0,0), Quaternion.Euler(0f, (float)(360/numBlades*i),0f), parentObject);
            blades[i].transform.localPosition = new Vector3(0,0,0);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        parentObject.transform.localRotation = Quaternion.Euler(0f, (float)time.TotalSeconds * degreesPerSecond,0f);
    }
}
