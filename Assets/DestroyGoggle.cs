using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGoggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Goggle"))
        {
            Debug.Log("Goggles Distroyed");
            EventManager.onStepCompleteInvoke(); // when the goggle is destroyed, we are calling the onStepCompleteInvoke method to notify that the step is complete.
            Debug.Log("Step1 Completed");
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        
    }
}
