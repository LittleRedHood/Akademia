using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "toadstool")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            Player.points += 2;
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Player")
        {
            Destroy(gameObject);
        }
    }
}
