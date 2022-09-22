using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class NewInputSystem_Player : MonoBehaviour
{
    [Header("Base Move Element")]
    float h;
    float v;
    Vector3 _dir;
    Vector3 _MoveDir;
    Vector3 _NewMoveDir;
    float speed = 1;

    [Space(10)]
    [Header("New Move Element")]
    float new_h;

    void Update()
    {
        // New Input System - Send Message
        bool hasControl = (_MoveDir != Vector3.zero);
        if (hasControl)
        {
            transform.Translate(_MoveDir * speed * Time.deltaTime);
        }

        bool hasEventControl = (_NewMoveDir != Vector3.zero);
        if (hasEventControl)
        {
            transform.Translate(_NewMoveDir * speed * Time.deltaTime);
        }
    }

#region SEND_MESSAGE
    // New Input System - Send Message
    void OnMove(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>();
        _MoveDir = new Vector3(direction.x, 0, direction.y);
        Debug.Log("OnMove");
    }
#endregion

#region UNITY_EVENTS
    // New Input System - Unity Events
    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 _dir = context.ReadValue<Vector2>();
        _NewMoveDir = new Vector3(_dir.x, 0, _dir.y);
        Debug.Log("NewOnMove");
    }
#endregion

    public void BasicMove()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        _dir = new Vector3(h, 0, v);
        _dir.Normalize();
        transform.Translate(_dir * speed * Time.deltaTime);
    }
}
