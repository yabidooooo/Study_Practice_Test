using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteSubject : MonoBehaviour, ISubject
{
    List<Observer> observers = new List<Observer>();

    public void AddObserver(Observer observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(Observer observer)
    {
        if (observers.IndexOf(observer) > 0)
        {
            observers.Remove(observer);
        }
    }

    private void Start()
    {
        Observer obj1 = new ConcreteObserver1();
        Observer obj2 = new ConcreteObserver2();

        AddObserver(obj1);
        AddObserver(obj2);
    }

    public void Update()
    {
        foreach (Observer o in observers)
        {
            o.Update();
        }
    }
}
