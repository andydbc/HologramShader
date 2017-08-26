using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public float Speed = 5.0f;

    public bool RotateOnX = true;
    public bool RotateOnY = true;
    public bool RotateOnZ = true;
	
	void Update ()
    {
        Vector3 rotFactor = Vector3.one * Speed;

        if (!RotateOnX) rotFactor.x = 0;
        if (!RotateOnY) rotFactor.y = 0;
        if (!RotateOnZ) rotFactor.z = 0;

        transform.Rotate(
            rotFactor * Time.deltaTime
       );
    }
}
