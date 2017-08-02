using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour {
    public GameObject projectile;
    private float speedBullet=5;
    private float Delay=5;
    private Quaternion atack; 

	
	void Start () {
        StartCoroutine(Shoots());
        atack.x = 20;
        atack.y = 20;
        atack.z = 0;
     
	}
	
	
	void Update () {
    }

    IEnumerator Shoots()
    {
        while (true)

        {
            yield return  new WaitForSeconds(Delay);

            GameObject clone = (GameObject)Instantiate(projectile, transform.position, atack/*Quaternion.identity*/);
            clone.GetComponent<Rigidbody2D>().velocity = -transform.right * speedBullet;
        }
          
    }
}
