using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SlideChair : MonoBehaviour
{
    public Transform chairObject;
    public float minZ = -1f;
    public float speed = 0.01f;

    bool slideback = true;
    float zMove = 0f;

    // Update is called once per frame
    void Start(){
        
    }

    void Update()
    {
        UpdateSlide();
    }

    void UpdateSlide(){
        var rand = new Random();
        if (zMove == 0f && rand.Next(1,300) > 1){
            return;
        }
        
        if (slideback){
            zMove -= (float)speed;
        }else{
            zMove += (float)speed;
        }

        if (zMove <= minZ){ slideback = false;}
        if (zMove >= 0){slideback = true;zMove = 0f;}
        chairObject.localPosition = new Vector3(0, 0, zMove);
        
    }
}
