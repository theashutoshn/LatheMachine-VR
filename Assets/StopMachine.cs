using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;
using UnityEngine.XR.Interaction.Toolkit;

public class StopMachine : GenericSteps
{
    public GameObject stopButton;

    public void Start()
    {
        
    }
    public override void CustomStart()
    {
        stopButton.GetComponent<XRSimpleInteractable>().enabled = true;
        stopButton.GetComponent<XRPokeFilter>().enabled = true;
        stopButton.GetComponent<XRPokeFollowAffordance>().enabled = true;
        Debug.Log("Step 8 Started");
    }
}
