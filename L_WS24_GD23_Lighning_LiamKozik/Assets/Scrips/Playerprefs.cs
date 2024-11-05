using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TMP_InputField InputField;

    public void Save()
    {
        PlayerPrefs.SetString("inputfieldText", InputField.text);
    }

    public void Load()
    {
        InputField.text = PlayerPrefs.GetString("inputfieldText");
    }
    
    public void Delete()
    {

        PlayerPrefs.DeleteAll();
            InputField.text = string.Empty;
    }

}
