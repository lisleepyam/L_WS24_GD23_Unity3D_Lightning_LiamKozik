using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRandomColor : MonoBehaviour
{
    private SammeldieFarben SammeldieFarben;
    private void Awake()
    {
        SammeldieFarben = GameObject.Find("Logic").GetComponent<SammeldieFarben>();
    }
    private void Start()
    {

        GetComponent<MeshRenderer>().material.color = Random.ColorHSV();

    }
    private void OnMouseDown()
    {
        SammeldieFarben.AddColorToList(GetComponent<MeshRenderer>().material.color);
        //Logicprint(GetComponent<MeshRenderer>().material.color);
        Destroy(gameObject);
    }
}
