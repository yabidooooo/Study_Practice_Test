using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform destination;

    public float getDistanceToDestination()
    {
        float distance = Vector3.Distance(transform.position, destination.position);
        return distance;
    }

    public void Move(Vector3 direction, float speed)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
