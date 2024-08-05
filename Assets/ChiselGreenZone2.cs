using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChiselGreenZone2 : MonoBehaviour
{
    private float elaspedTime = 0;
    private int endTime = 3;
    public GameObject woodBlock2;
    public GameObject woodBlock3;
    

    private void Start()
    {
        Debug.Log("ChiselGreenZone Started");
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Chisel1"))
        {
            elaspedTime += Time.deltaTime;
            if (elaspedTime >= endTime)
            {
                woodBlock2.SetActive(false);
                woodBlock3.SetActive(true);
                Debug.Log("Wood 2 Changed");
                EventManager.onStepCompleteInvoke();
                Debug.Log("Step 7 Completed");
            }
        }
    }
}
