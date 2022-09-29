using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RaycastEventSystem : MonoBehaviour
{
    RaycastHit hit;

    private GameObject prevButton;
    private GameObject currButton;

    private void Update()
    {

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            GazeButton();
            GazeObject();
        }
    }

    void GazeButton()
    {
        // ���� ������ ������ �̺�Ʈ ������ ����
        PointerEventData _data = new PointerEventData(EventSystem.current);

        // ���� �����ϰ� �ִ� ���� ��ư�� ���
        if (hit.collider.gameObject.layer == 5)
        {
            // ������ ���� ��ư�� ���� �����ϴ� ��ư�� ����
            currButton = hit.collider.gameObject;

            // ���� ��ư�� ���� �����ϴ� ��ư�� ���� �ٸ� ���
            if (currButton != prevButton)
            {
                // ���� �����ϴ� ��ư�� PointerEnter �̺�Ʈ ����
                ExecuteEvents.Execute(currButton, _data, ExecuteEvents.pointerEnterHandler);

                // ������ �����ߴ� ��ư�� PointerExit �̺�Ʈ ����
                ExecuteEvents.Execute(prevButton, _data, ExecuteEvents.pointerExitHandler);

                // ���� ��ư�� ������ ����
                prevButton = currButton;
            }
            else
            {
                // ��ƼŬ�� ��ư �̿��� �ٸ� ���� �������� ��, ���� ��ư�� PointerExit �̺�Ʈ ����
                ReleaseButton();
            }
        }
    }

    // ��ƼŬ�� ��ư �̿��� �ٸ� ���� �������� ��, ���� ��ư�� �ʱ�ȭ
    private void ReleaseButton()
    {
        // ���� ������ ������ �̺�Ʈ ������ ����
        PointerEventData _data_ = new PointerEventData(EventSystem.current);

        // ������ �����ߴ� ��ư�� ���� ���
        if (prevButton != null)
        {
            // ������ �����ߴ� ��ư�� PointerExit �̺�Ʈ ����
            ExecuteEvents.Execute(prevButton, _data_, ExecuteEvents.pointerExitHandler);

            prevButton = null;
        }
    }

    private void GazeObject()
    {
        PointerEventData data = new PointerEventData(EventSystem.current);

        if (hit.collider.name == "Cube")
        {
            ExecuteEvents.Execute(hit.collider.gameObject, data, ExecuteEvents.pointerEnterHandler);
        }
    }
}
