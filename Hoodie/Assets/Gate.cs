using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		int id = Application.loadedLevel;

        if (Player.currentLvl == 3)
        {
            DataInfoClass.addUser = true;
        }

        Application.LoadLevel (id + 1);
        
	}
}
