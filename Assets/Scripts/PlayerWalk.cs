using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public int playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")){
            Vector3 forwardVector = Camera.main.transform.forward;
            Vector3 levelForwardVector = new Vector3(forwardVector.x, 0, forwardVector.z);
            //transform.position = transform.position + levelForwardVector * playerSpeed * Time.deltaTime;
            GetComponent<Rigidbody>().AddForce(levelForwardVector * playerSpeed );
        }
        
    }
}
