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
                // ���� �̷��� ó��.
                //instance = this;

                // ���⼭�� T�� this�� �ǵ��� �ؾ��Ѵ�.
                // T�� Class�ϱ�........
                // �׳� ���� �޾ƿ��°� �ȵǰ�....
                // ã�ƾ��ϴµ�...
                // ã�� �Լ��� �ȵǳ�...

            }
            return instance;
        }
    }
}
