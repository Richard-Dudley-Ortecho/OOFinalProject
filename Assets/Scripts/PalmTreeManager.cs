using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalmTreeManager : MonoBehaviour
{
    public GameObject palmObject;
    public Transform parentObject;
    public GameObject[] palms;
    public int numTrees = 4;

    // Start is called before the first frame update
    void Start()
    {
        palms = new GameObject[numTrees];
        int i;
        for (i = 0; i<numTrees; i++){
            float randX = Random.Range(0.0f, 15.0f);
            //float randY = Random.Range(9.0f, 9.0f);
            float randZ = Random.Range(0.0f, 7.0f);
            Vector3 startPos = palmObject.transform.position;
            Vector3 location = new Vector3(startPos.x + randX,  startPos.y , startPos.z +randZ);
            palms[i] = Instantiate(palmObject, new Vector3(0,0,0), Quaternion.Euler(0f, 0f ,0f), parentObject);
            palms[i].transform.position = location;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Generate at random spots on property
    }
}
