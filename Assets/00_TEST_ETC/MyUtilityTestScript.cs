using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class MyUtilityTestScript : MonoBehaviour
{
    public int testNumber;

    void Start()
    {
        Debug.Log("�׽�Ʈ ���� ��ǥ : " + StringFormatScript.MyApplyDecimalComma(testNumber));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("�׽�Ʈ ���� ��ǥ : " + StringFormatScript.MyApplyDecimalComma(testNumber));
        }
    }
}
