using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Loops : MonoBehaviour
{
    public GameObject[] cubes;
    private int count = 10;
    private void Awake()
    {
        cubes = GameObject.FindGameObjectsWithTag("Cube");
    }
    public void StartLoops()
    {
        ChangeColors();
        MoveUp();
        Shrink();
        print();
    }
    void ChangeColors()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            MeshRenderer cubeRenderer = cubes[i].GetComponent<MeshRenderer>();
            cubeRenderer.material.color = Random.ColorHSV();

        }
    }
        private void MoveUp()
        {
         
        foreach(GameObject cube in cubes)
        {
                cube.transform.position += new Vector3(0, 1.5f, 0);
        }

    }
    private void Shrink()
    {
        while (count >0)
           
        {
            count--;
            foreach (GameObject cube in cubes)
            {
                if (cube.transform.localScale.x > 0.1f)
                {
                    cube.transform.localScale *= 0.9f;
                }
            }
        }
    }
    private void print()
    {
        do
        {
            print("Message");
            
        } while (count > 0);
    }
}
