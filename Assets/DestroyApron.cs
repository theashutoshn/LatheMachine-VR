using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyApron : MonoBehaviour
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
        if (other.gameObject.CompareTag("Apron"))
        {
            Debug.Log("Apron Distroyed");
            EventManager.onStepCompleteInvoke();
            Debug.Log("Step3 Completed");
            Destroy(other.gameObject);
        }
    }
}
