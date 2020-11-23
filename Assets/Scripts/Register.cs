using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Register : MonoBehavior
{
    private Register() {

    }

    private static Singleton _instance;

    public static Singleton GetInstance()
    {
        if(_instance == null)
        {
            _instance  = new Singleton();
        }
        return _instance;
    }
}