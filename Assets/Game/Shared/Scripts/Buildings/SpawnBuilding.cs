using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBuilding : MonoBehaviour
{
    public GameObject[] buildings;

    void Start()
    {
        int myBuilding = Random.Range(0, buildings.Length);
        Instantiate(buildings[myBuilding], transform.position, Quaternion.identity);
    }

}
