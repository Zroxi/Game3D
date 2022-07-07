using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : MonoBehaviour
{
    int itemCount;

    public GameObject[] myObjects;
   


    void Update()
    {
        itemCount = GameObject.FindGameObjectsWithTag("Poison").Length;
        if (itemCount < 5)
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-25, 25), 1, Random.Range(-25, 25));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
    }
}