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
            //Instantiate(gamePastPreFab).gameObject.transform.position = transform.position;
           Instantiate(gamePastPreFab, new Vector3(Random.Range(-3.866f, 3.866f), -0.308f, Random.Range(-2.589f, -3.608f)) ,Quaternion.identity);
        }
    }
}
