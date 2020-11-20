using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerLineUp : IObserver
{
    public CustomerBehavior lineUpCustomer1, lineUpCustomer2, lineUpCustomer3;



    public override void OnNotify(int timePassed)
    {
        lineUpCustomer1.updateTimePassed(timePassed);
        lineUpCustomer2.updateTimePassed(timePassed);
        lineUpCustomer3.updateTimePassed(timePassed);
        if(timePassed == 5) {
            activateScedule(lineUpCustomer1);
        }
        if (timePassed == 25) {
            activateScedule(lineUpCustomer2);
        }

        if (timePassed == 45) {
            activateScedule(lineUpCustomer3);
        }
    }

    public void activateScedule(CustomerBehavior c)
    {
        c.activateCustomer();
    }
}
