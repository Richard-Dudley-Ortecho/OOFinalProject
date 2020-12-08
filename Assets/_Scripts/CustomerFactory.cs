using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerFactory : MonoBehaviour
{
    public void createRandomCustomer(CustomerBehavior cb) 
    {
        cb = new CustomerBehavior();
        int typeOfCustomer = Random.Range(0, 3);
        // switch (typeOfCustomer)
        // {
        // case 1:
        //     print ("Ulg, glib, Pblblblblb");
        //     break;
        // default:
        //     print ("Incorrect intelligence level.");
        //     break;
        // }
        cb.timeRemaining =  Random.Range(15, 46);
        cb.rollType = Random.Range(1, 4);
        cb.startseconds = -1;

    }
}
