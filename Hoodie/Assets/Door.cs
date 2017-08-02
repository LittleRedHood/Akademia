using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag == "yellow_door")
        {
            if (Player.yellow_key)
            {
                Destroy(gameObject);
                Player.points = Player.points + 4;
            }
        }
        if (gameObject.tag == "red_door")
        {
            if (Player.red_key)
            {
                Destroy(gameObject);
                Player.points = Player.points + 4;
            }
        }
        if (gameObject.tag == "green_door")
        {
            if (Player.green_key)
            {
                Destroy(gameObject);
                Player.points = Player.points + 4;
            }
        }
    }
}
