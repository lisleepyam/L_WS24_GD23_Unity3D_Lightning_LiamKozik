using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSave : MonoBehaviour
{
   [SerializeField] private Color color;
    private string colorString;

    
    public void SaveColor()
    {
        color = GetComponent<MeshRenderer>().material.color;
        colorString = ColorUtility.ToHtmlStringRGBA(color);
        PlayerPrefs.SetString("colorString",colorString);
        print(" color saved: " + colorString);
    }
    public void LoadColor()
    {
        colorString = PlayerPrefs.GetString("colorString");

        if (ColorUtility.TryParseHtmlString("#"+ colorString, out color))
        {
            GetComponent<MeshRenderer>().material.color = color;
            print(" Color setted:" + colorString);
        }

        else
        {
            print("Error to set color");
        }
    }
}
