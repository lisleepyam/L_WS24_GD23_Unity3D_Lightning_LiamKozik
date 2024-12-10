using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            Destroy(other.gameObject);
        }
    }
}
