using InControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputSystemInControl : MonoBehaviour
{
    private Vector3 moveDirextion;
    private float moveSpeed = 4f;

    float x;
    float y;

    float getHorizontal()
    {
        return InputManager.ActiveDevice.GetControl(InputControlType.Analog4);
    }
    float getVertical()
    {
        return InputManager.ActiveDevice.GetControl(InputControlType.Analog5);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        x = getHorizontal();
        y = getVertical();

        bool hasControl = (moveDirextion != Vector3.zero);

        if (hasControl)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
    }

    public void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        if (input != null)
        {
            moveDirextion = new Vector3(input.x, 0, input.y);
            Debug.Log($"SEND_MESSAGE : {input.magnitude}");
        }

    }

}
