﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockDay : MonoBehaviour
{
    //this is the start of a new day
    //triggered when the player clicks "Start Day"

    // Start is called before the first frame update

    bool dayHasStarted = false;

    //-- set start time 00:00
    public int minutes = 0;
    public int hour = 0;
    
    //-- time speed factor
    public float clockSpeed = 1.0f;     // 1.0f = realtime, < 1.0f = slower, > 1.0f = faster

    //-- internal vars
    int seconds;
    int secondsElasped;
    float msecs;
    GameObject pointerSeconds;
    GameObject pointerMinutes;
    GameObject pointerHours;

    IObservable observable = new IObservable();

    void Start() 
    {
        pointerSeconds = transform.Find("rotation_axis_pointer_seconds").gameObject;
        pointerMinutes = transform.Find("rotation_axis_pointer_minutes").gameObject;
        pointerHours   = transform.Find("rotation_axis_pointer_hour").gameObject;

        msecs = 0.0f;
        seconds = 0;
        secondsElasped = seconds;
    }

    void addObject (IObserver observer) {
        observable.AddObserver(observer);
    }

    public void startDay () {dayHasStarted = true; }
    public void stopTime () {dayHasStarted = false; }
    public void resetTime() {
        dayHasStarted = false;
        seconds = 0;
        secondsElasped = seconds;
        minutes = 0;
        hour = 0;
        pointerSeconds.transform.localEulerAngles = new Vector3(0.0f, 0.0f,  0.0f);
        pointerMinutes.transform.localEulerAngles = new Vector3(0.0f, 0.0f,  0.0f);
        pointerHours.transform.localEulerAngles   = new Vector3(0.0f, 0.0f,  0.0f);
        
    }
    
//-----------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------
    void Update() 
    {
        if (dayHasStarted) {
            msecs += Time.deltaTime * clockSpeed;
            if(msecs >= 1.0f)
            {
                msecs -= 1.0f;
                seconds++;
                if(seconds >= 60)
                {
                    seconds = 0;
                    minutes++;
                    if(minutes > 60)
                    {
                        minutes = 0;
                        hour++;
                        if(hour >= 24)
                            hour = 0;
                    }
                }
            }


            //-- calculate pointer angles
            if (secondsElasped !=seconds) {
                secondsElasped = seconds;
                observable.Notify(seconds);
            }

            float rotationSeconds = (360.0f / 60.0f)  * seconds;
            float rotationMinutes = (360.0f / 60.0f)  * minutes;
            float rotationHours   = ((360.0f / 12.0f) * hour) + ((360.0f / (60.0f * 12.0f)) * minutes);

            //-- draw pointers
            pointerSeconds.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationSeconds);
            pointerMinutes.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationMinutes);
            pointerHours.transform.localEulerAngles   = new Vector3(0.0f, 0.0f, rotationHours);

        } else {

        }
        
    }
}