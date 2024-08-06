using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatheCarriageGreenLoc1 : MonoBehaviour
{
    

    public void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("LatheCarriage"))
        {
            Debug.Log("Lathe Carriage Position Snapped");
            other.transform.position = this.transform.position;
        }
    }
}
