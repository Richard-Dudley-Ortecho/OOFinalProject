using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerLineUp : IObserver
{
    public CustomerBehavior lineUpCustomer1, lineUpCustomer2, lineUpCustomer3;
    public ClockDay cd;

    private void Start()
    {
        cd.addObject(this);
    }

    public override void OnNotify(int timePassed)
    {
        lineUpCustomer1.updateTimePassed(timePassed);
        lineUpCustomer2.updateTimePassed(timePassed);
        lineUpCustomer3.updateTimePassed(timePassed);
        if(timePassed == 1) {
            activateScedule(lineUpCustomer1);
        }
        if (timePassed == 15) {
            activateScedule(lineUpCustomer2);
        }

        if (timePassed == 35) {
            activateScedule(lineUpCustomer3);
        }
    }

    public void activateScedule(CustomerBehavior c)
    {
        c.activateCustomer();
    }
}
