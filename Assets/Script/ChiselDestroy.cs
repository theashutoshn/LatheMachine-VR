using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChiselDestroy : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Chisel Distroyed");
            Destroy(this.gameObject);
        }
    }
}
