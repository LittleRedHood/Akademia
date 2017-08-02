using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkPlatform : MonoBehaviour {

    private int _i;
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = true; //it is visible;
        _i = 0;
    }
    private void ChangeColor()
    {
        if (Application.loadedLevelName.Equals("lvl_1"))
            gameObject.GetComponent<SpriteRenderer>().color = Color.cyan;
        if (Application.loadedLevelName.Equals("lvl_2"))
            gameObject.GetComponent<SpriteRenderer>().color = Color.grey;
        if (Application.loadedLevelName.Equals("lvl_3"))
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
    }
    private void BackColor()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
    void Update()
    {
        _i++;
        if (_i % 331 == 0)ChangeColor(); 
        if (_i % 400 == 0)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
        if (_i % 431 == 0) BackColor();
        if (_i % 800 == 0)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
            gameObject.GetComponent<Collider2D>().enabled = true;
        }
    }
}
