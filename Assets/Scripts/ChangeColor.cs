using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public void Cyan()
    {
        GetComponent<Renderer>().material.color = Color.cyan;
    }

    public void CabinetWhite()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
    public void Gray()
    {
        GetComponent<Renderer>().material.color = Color.gray;
    }

    public void AccentRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    
}
