using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class OpenLaptop : MonoBehaviour
{   
    [SerializeField]
    public Transform laptopTop;
    public float minX = 0f;
    public float maxX = 90f;
    public float speed = 5.0f;

    bool close = true;
    float angle = 90f;
    
    
    void Update()
    {
        RotateGameObject();
    }

    public void RotateGameObject() {
        var rand = new Random();
        if (angle == maxX && rand.Next(1,300) > 1){
            return;
        }

        if (close){
            angle -= (float)speed;
        }else{
            angle += (float)speed;
        }

        if (angle <= minX){ close = false;angle = minX;}
        if (angle >= maxX){close = true;angle = maxX;}
        laptopTop.localRotation = Quaternion.Euler(angle,0f,0f);
    }
}
