using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerPrefsPosition : MonoBehaviour
{
    public GameObject Player;

    public void Save()
    {
        PlayerPrefs.SetFloat("Positionx", Player.transform.position.x);

        PlayerPrefs.SetFloat("Positiony", Player.transform.position.y);

        PlayerPrefs.SetFloat("Positionz", Player.transform.position.z);

        
    }

    public void Load()
    {
        Vector3 position = new Vector3(PlayerPrefs.GetFloat("Positionx"), PlayerPrefs.GetFloat("Positiony"), PlayerPrefs.GetFloat("Positionz"));
        Player.transform.position = position;

        if (PlayerPrefs.HasKey("Positionx"))
        {
            print("no position saved");
        }
        
    }


}
