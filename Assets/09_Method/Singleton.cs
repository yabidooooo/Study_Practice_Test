using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T instance = null;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                // 보통 이렇게 처리.
                //instance = this;

                // 여기서는 T가 this가 되도록 해야한다.
                // T는 Class니까........
                // 그냥 직접 받아오는건 안되고....
                // 찾아야하는데...
                // 찾는 함수도 안되네...

            }
            return instance;
        }
    }
}
