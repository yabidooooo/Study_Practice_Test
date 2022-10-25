using UnityEngine;

public class Singleton<T> where T : Singleton<T>, new()
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new T();
            }
            return _instance;
        }
    }
}

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
