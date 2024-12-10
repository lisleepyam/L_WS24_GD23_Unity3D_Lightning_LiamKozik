using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 mousePosition;
    private Color col;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();

        //wird von keinen anderen Objekten während des Drags beeinflusst
        GetComponent<Rigidbody>().isKinematic = true;

        //färben des Objects
        if (GetComponent<MeshRenderer>() != null)
        {
            col = GetComponent<MeshRenderer>().material.color;
            GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }

    private void OnMouseUp()
    {
        GetComponent<Rigidbody>().isKinematic = false;

        //setzt die Farbe des Objects zurück
        if (GetComponent<MeshRenderer>() != null)
        {
            GetComponent<MeshRenderer>().material.color = col;
        }
    }

}
