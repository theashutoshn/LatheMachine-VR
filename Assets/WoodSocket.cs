using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WoodSocket : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("FirstWood"))
        {
            EventManager.onStepCompleteInvoke();
            Debug.Log("Step 4 Complete");
        }
    }
}
