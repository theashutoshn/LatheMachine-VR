using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FirstWoodGrab : GenericSteps
{
    
    public GameObject firstWood;
    public override void CustomStart()
    {
        firstWood.GetComponent<XRGrabInteractable>().enabled = true;
        Debug.Log("Step 4 Started");
    }
}
