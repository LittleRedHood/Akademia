using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "background" )
        {
            Destroy(gameObject);

        }
    }
}
