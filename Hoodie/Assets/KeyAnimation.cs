using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAnimation : MonoBehaviour {

	void Update () {
        transform.RotateAround(transform.position, Vector3.up, 80 * Time.deltaTime);
	}
}
