using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WearApron : GenericSteps
{
    public GameObject apron;
   
    public override void CustomStart()
    {
        apron.GetComponent<XRGrabInteractable>().enabled = true;
        Debug.Log("Step 3 Started");
    }
}
