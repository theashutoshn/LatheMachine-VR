using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Chisel1Collision : MonoBehaviour
{
    
   
    private float elaspedTime = 0;
    private int endTime = 3;
    public GameObject woodBlock1Socket;
    public GameObject woodBlock2;
    public GameObject FirstWood;

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
                woodBlock1Socket.SetActive(false);
                FirstWood.SetActive(false);
                woodBlock2.SetActive(true);
                Debug.Log("Wood Changed");
            }
        }
    }
}
