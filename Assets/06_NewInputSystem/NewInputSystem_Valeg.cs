using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class NewInputSystem_Valeg : MonoBehaviour
{
    Vector3 direction;

    void Start()
    {

    }

    void Update()
    {
        bool hasControl = (direction != Vector3.zero);
        if (hasControl)
        {
            transform.Translate(direction * 2 * Time.deltaTime);
        }
    }

    void OnMove(InputValue value)
    {
        float x = value.Get<float>();
        Axis y = value.Get<Axis>();

        Debug.Log("x :" + x);
        Debug.Log("y :" + y);
    }

    void OnNewMove(InputValue _value)
    {
        Vector2 _dir = _value.Get<Vector2>();
        direction = new Vector3(_dir.x, 0, _dir.y);
        Debug.Log(_dir.x + " / " + _dir.y);
    }
}
