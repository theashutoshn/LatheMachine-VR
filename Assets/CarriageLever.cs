using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarriageLever : MonoBehaviour
{

    private void Update()
    {
        if(transform.rotation.z < -90)
        {
            Debug.Log("Lever Rotated");
        }
    }
}
