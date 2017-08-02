using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour {
    
    public static bool gameOver = false;
    const int _lifeMax = 6;
   
    void Start () {
        // ATTENTION !!!
        // when you want to test only one level you need to uncomment first code line below
        // when you want to test all game you need to comment first code line below

        //lifeAmount = 3;
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "addLife")
        {
            if (Player.lifeAmount < _lifeMax)
                Player.lifeAmount++;
        }
    }
    void OnGUI()
    {
        if (Player.lifeAmount == 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("heart1"));
            gameOver = true;
        }
        else
        {
            for (int i = _lifeMax; i > 0; i--)
            {
                GameObject.FindGameObjectWithTag("heart" + i).GetComponent<Renderer>().enabled = true;
            }
            for (int i = _lifeMax; i > Player.lifeAmount; i--)
            {
                GameObject.FindGameObjectWithTag("heart" + i).GetComponent<Renderer>().enabled = false;
            }
        }

    }
}
