using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentScript : MonoBehaviour
{
    public int zero = 0;

    void Start()
    {
        Debug.Log(this.gameObject.name + zero + Time.time);
    }

    void Update()
    {
        
    }
}
