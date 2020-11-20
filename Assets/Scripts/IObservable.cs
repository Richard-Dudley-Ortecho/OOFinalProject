using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IObservable : MonoBehaviour
{
    List<IObserver> observers = new List<IObserver>();

    public void Notify(int typeOfNotification)
    {
        for (int i=0; i<observers.Count; i++)
        {
            observers[i].OnNotify(typeOfNotification);
        }
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        //TODO
    }
}

public abstract class IObserver : MonoBehaviour
{
    public abstract void OnNotify(int notifcationType);
}