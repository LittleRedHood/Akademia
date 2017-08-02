using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);

        if (gameObject.tag == "yellow_key")
            Player.yellow_key = true;

        if (gameObject.tag == "red_key")
            Player.red_key = true;

        if (gameObject.tag == "green_key")
            Player.green_key = true;
    }
}
