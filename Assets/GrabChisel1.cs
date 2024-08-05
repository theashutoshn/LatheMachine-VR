using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabChisel1 : GenericSteps
{
    public GameObject chisel1;
    public GameObject chiselGreenZone;
   
    public override void CustomStart()
    {
        chisel1.GetComponent<XRGrabInteractable>().enabled = true;
        chiselGreenZone.SetActive(true);
        Debug.Log("Step 7 Started");
    }

}
