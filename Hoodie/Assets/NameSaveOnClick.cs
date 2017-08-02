using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameSaveOnClick : MonoBehaviour {
    public InputField iField;
    public static  string  userName;

    public void OnMouseUp()
    {
       
        userName= iField.text;
        Debug.Log(userName);

        Application.LoadLevel("lvl_1");
        DataInfoClass.isLoadFile = false;

    }
}
