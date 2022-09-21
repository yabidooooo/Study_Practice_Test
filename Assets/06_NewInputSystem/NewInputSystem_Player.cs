using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputSystem_Player : MonoBehaviour
{
    [Header("Base Move Element")]
    float h;
    float v;
    Vector3 dir;
    float speed;

    [Space(10)]
    [Header("New Move Element")]
    float new_h;

    void Start()
    {
        speed = 1;
    }

    void Update()
    {

    }

#region SEND_MESSAGE
    // New Input System - Send Message
    void OnMove(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>();
        Debug.Log("Send Message");
    }
#endregion


#region UNITY_EVENTS
    // New Input System - Unity Events
    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 _dir = context.ReadValue<Vector2>();
        Vector3 moveDir = new Vector3(_dir.x, 0, _dir.y);
        Debug.Log("Invoke Unity Events");
    }
    #endregion

    public void BasicMove()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        dir = new Vector3(h, 0, v);
        dir.Normalize();
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
