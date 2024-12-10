using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject gamePastPreFab;

   void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(gamePastPreFab).gameObject.transform.position = transform.position;
            //Instantiate(gamePastPreFab, new Vector3[Random.Range(-5f, 3f), 3, Random.Range(8f, -11,5f)].Ouaternion.Identity);
        }
    }
}
