using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public ActionObject actionPrefab;
    public TestObject testPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newObject = Instantiate(actionPrefab.gameObject, transform.position, Quaternion.identity);
            AddObject(newObject);

            GameObject newObject2 = Instantiate(testPrefab.gameObject, transform.position, Quaternion.identity);
            AddObject(newObject2);
        }
    }

    public void AddObject(GameObject actObj)
    {
        ActionTest.Instance.RegisterObject(actObj);
    }
}
