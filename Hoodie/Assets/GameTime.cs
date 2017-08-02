using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour {
    
    GUIStyle _infoStyle = new GUIStyle();

    void Start () {
        _infoStyle.fontSize = 35;
        _infoStyle.normal.textColor = Color.white;
        _infoStyle.fontStyle = FontStyle.Bold; 
    }
    void OnGUI()
    {
        if (Player.lifeAmount != 0)
            GUI.Box(new Rect(900, 10, 70, 20), "Time:  " + ((int)Player.timer).ToString(), _infoStyle);
    }
    
}
