using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WearGoggle : GenericSteps
{
    public GameObject goggle;
    public override void CustomStart()
    {
        goggle.GetComponent<XRGrabInteractable>().enabled = true;
        Debug.Log("Step1 Started");
    }
}
