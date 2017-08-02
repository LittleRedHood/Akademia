using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    
    public Transform hoodieCopy;
    public Transform respawnPoint;
    public Transform shootRespawn;
    public GameObject shootCopy;
    GameObject _shoot;
    bool _ifShoot = false;

    public void SpecialAbility()
    {
        if (_ifShoot == false) return;
        _shoot = Instantiate(shootCopy, shootRespawn.position, shootRespawn.rotation);
       
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)&&(Player.points >=3))
        {
            Player.points -=3;
            _ifShoot = true;
            SpecialAbility();
        }
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "background" || col.gameObject.tag == "enemy")
        {
            hoodieCopy.position = respawnPoint.position;
        }  
    }
}
