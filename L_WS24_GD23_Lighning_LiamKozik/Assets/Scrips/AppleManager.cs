using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleManager : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    public int count = 8;

    public GameObject[] itemsarray;
    private void Start()
    {
        itemsarray = GameObject.FindGameObjectsWithTag("Apple");
    }

}
