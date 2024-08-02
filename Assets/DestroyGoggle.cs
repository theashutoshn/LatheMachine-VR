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
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Goggles Distroyed");
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        
    }
}
