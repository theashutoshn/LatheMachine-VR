using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMask : MonoBehaviour
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
        if (other.gameObject.CompareTag("Mask"))
        {
            Debug.Log("Mask Distroyed");
            EventManager.onStepCompleteInvoke();
            Debug.Log("Step2 Completed");
            Destroy(other.gameObject);
        }
    }
}
