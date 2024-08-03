using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WearMask : GenericSteps
{
    public GameObject mask;

    public override void CustomStart() // since we cannot call start method, we create custom start method to be called in Game Manager
    {
        mask.GetComponent<XRGrabInteractable>().enabled = true;
        Debug.Log("Step2 Started");
    }
}
