using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollSubmitting : MonoBehaviour
{
    public GameObject lineUpObj;
    List<GameObject> lineUpMeals = new List<GameObject>();
    List<float> lineUpDistances = new List<float>();
    Vector3 startPosition;
    Quaternion startRotation;

    public RollMaking rollMaker;
    public float speed = 0.01f;
    public float maxDisplacement = -3.5f;

    void Start(){
        startPosition = lineUpObj.transform.position;
        startPosition.x = startPosition.x + 2.0f;
        startRotation = Quaternion.Euler(0f, 0f ,0f);
    }

    void Update(){
        updateSlide();
    }

    public void submitPlate(){
        Debug.Log("Plate");
        lineUpMeals.Add( Instantiate(rollMaker.plate, startPosition, startRotation, lineUpObj.transform));
        lineUpDistances.Add(0.0f);
    }


    public void updateSlide(){
        int numPlates = lineUpMeals.Count;
        float distanceMoved;
        for (int i=0; i < numPlates; i++){
            if (lineUpMeals[i] != null){
                distanceMoved = lineUpDistances[i] - speed;
                lineUpDistances[i] = distanceMoved;
                lineUpMeals[i].transform.position = new Vector3(startPosition.x + distanceMoved, startPosition.y, startPosition.z);
                if (distanceMoved < maxDisplacement){
                    Debug.Log(maxDisplacement);
                    Debug.Log(distanceMoved);
                    Debug.Log("DESTROY");
                    //lineUpMeals[i].GetComponent<Renderer>().enabled = false;
                    lineUpMeals[i].SetActive(false);
                    lineUpMeals[i] = null;
                }
            }
        } 

        /*if (lineUpDistances.Count >= 1){
            if (lineUpDistances[i] < maxDisplacement){
                lineUpMeals[i]
            }
        }*/
        
    }
}

