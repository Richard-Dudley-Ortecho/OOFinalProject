using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSimple : MonoBehaviour
{
    public Transform hoursObject, minutesObject, secondsObject;
    // Start is called before the first frame update
    void Awake() {
        Debug.Log("Test");
    }

    // Update is called once per frame
    void Update()
    {
        UpdateContinuous();
    }

    void UpdateContinuous(){
        TimeSpan time = DateTime.Now.TimeOfDay;
        
        const float degreesPerHour = 30f, degreesPerMinute = 6f, degreesPerSecond = 6f;

        hoursObject.localRotation = Quaternion.Euler(0f, (float)time.TotalHours * degreesPerHour,0f);
        minutesObject.localRotation = Quaternion.Euler(0f, (float)time.TotalMinutes * degreesPerMinute,0f);
        secondsObject.localRotation = Quaternion.Euler(0f, (float)time.TotalSeconds * degreesPerSecond,0f);

    }
}
