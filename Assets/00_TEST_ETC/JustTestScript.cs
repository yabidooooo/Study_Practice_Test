using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustTestScript : MonoBehaviour
{
    [SerializeField] private Transform[] childTr;

    private void Awake()
    {
        childTr = new Transform[2];
    }

    void Start()
    {
        childTr[0] = transform.GetChild(0).gameObject.transform.GetComponent<Transform>();
        childTr[1] = transform.GetChild(1).gameObject.transform.GetComponent<Transform>();
    }

    void Update()
    {
        
    }
}
