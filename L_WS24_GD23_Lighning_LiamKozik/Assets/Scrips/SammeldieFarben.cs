using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SammeldieFarben : MonoBehaviour
{
    public List<Color> colors = new List<Color>();
    public int maxColor = 3;

   
    public GameObject[] colorArray;

    private void Start()
    {
        colorArray = GameObject.FindGameObjectsWithTag("Circle");
    }
    public void AddColorToList(Color color)
    {
        colors.Add(color); 
        if(colors.Count == maxColor)
        {
           // print("AlleFarbengesammelt");
         foreach(Color color_ in colors) 
            {
                print(color_);
            }
        }
    }
    
}
