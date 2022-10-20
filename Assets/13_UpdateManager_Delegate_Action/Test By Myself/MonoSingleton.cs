using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                var gameObject = new GameObject(typeof(T).Name);
                _instance = gameObject.AddComponent<T>();

                DontDestroyOnLoad(gameObject);
            }

            return _instance;
        }
    }
}