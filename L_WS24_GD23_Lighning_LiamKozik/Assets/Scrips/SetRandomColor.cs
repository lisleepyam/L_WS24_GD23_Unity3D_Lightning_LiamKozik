using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRandomColor : MonoBehaviour
{
    private void Start()
    {

        GetComponent<MeshRenderer>().material.color = Random.ColorHSV();

    }
    private void OnMouseDown()
    {
        print(GetComponent<MeshRenderer>().material.color);
    }
}
