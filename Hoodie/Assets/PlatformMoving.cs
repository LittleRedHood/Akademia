using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoving : MonoBehaviour {

    Transform _firstPosition;
    float _i;

	void Start () {
        _firstPosition = transform;
        _i = 0;
	}

	void Update () {
        _i++;
        transform.RotateAround(_firstPosition.position + _firstPosition.right,Vector3.up,_i/2000);
        if (_i > 600)
        {
            _i = -600;
        }
    }
}
