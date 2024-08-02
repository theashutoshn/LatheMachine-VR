using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WearMask : GenericSteps
{
    public GameObject mask;

    public override void CustomStart()
    {
        mask.GetComponent<XRGrabInteractable>().enabled = true;
        Debug.Log("Step2 Started");
    }
}
