using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LeafManager : MonoBehaviour
{
    //Init Objects
    public GameObject leafObject;
    public Transform parentObject;
    public GameObject[] leaves;
    public int numLeaves = 6;
    public float swaySize = 0.3f;

    public Vector3[] posList;
    float xPos;
    
    // Start is called before the first frame update
    void Start()
    {
        //Initialize palm leaves on palm tree
        leaves = new GameObject[numLeaves];
        posList = new Vector3[numLeaves];
        int i;
        //moving leaves initialized
        for (i = 0; i < numLeaves; i++){
            leaves[i] = Instantiate(leafObject, new Vector3(0,0,0), Quaternion.Euler(0f, (float)(360/numLeaves*i),0f), parentObject);
            leaves[i].transform.localPosition = new Vector3(0,0,0);
            
        }   
        //still leaves initialized
        for (i = 0; i < numLeaves; i++){
            GameObject leaf = Instantiate(leafObject, new Vector3(0,0,0), Quaternion.Euler(0f, (float)(360/numLeaves*i),0f), parentObject);
            leaf.transform.localPosition = new Vector3(0,0,0);
            leaf.transform.localRotation = Quaternion.Euler(0f, 0f, 30f);
            
        } 

    }

    // Update is called once per frame
    void Update()
    {
        
        xPos = swaySize * Mathf.Sin(Time.time);
        //Debug.Log(xPos);

        //Sway ever so slightly
        for (int i = 0; i < numLeaves; i++){
            leaves[i].transform.localPosition = new Vector3(0f, xPos,0f);
        }
        
        
    }
}

//This code was followed closely to what was implemented in class