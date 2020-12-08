using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofManager : MonoBehaviour
{
    public GameObject tileObject;
    public Transform parentObject;
    public GameObject[] tiles;
    public int numTiles = 10;
    public float spacing = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        tiles = new GameObject[numTiles];
        float currX = tileObject.transform.localPosition.x;
        float currY = tileObject.transform.localPosition.y;
        float currZ = tileObject.transform.localPosition.z;
        float widthX = tileObject.transform.localScale.x;
        //Debug.Log(currX);
        //Debug.Log(currY);
        //Debug.Log(currZ);

        //Spread n tiles with some spacing
        for (int i = 0; i<numTiles; i++){
            
            Vector3 location = new Vector3((float)((widthX + spacing) * i) + currX, currY, currZ);
            tiles[i] = Instantiate(tileObject, new Vector3(0,0,0), Quaternion.Euler(0f, 0f ,0f), parentObject);
            tiles[i].transform.localPosition = location;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
