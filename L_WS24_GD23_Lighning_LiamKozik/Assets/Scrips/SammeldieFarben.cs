using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SammeldieFarben : MonoBehaviour
{
    public List<Color> colors = new List<Color>();
    public int maxColor = 3;

    private void Start()
    {
        AddColorToList();
    }
    public void AddColorToList()
    {
        colors.Add(Color.blue); 
    }
}
