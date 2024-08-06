using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenCarriage : GenericSteps
{
    public GameObject carriageLock;
    
    public override void CustomStart()
    {
        carriageLock.GetComponent<XRGrabInteractable>().enabled = true;
        Debug.Log("Step 9 Started");
        //EventManager.onStepCompleteInvoke();
        Debug.Log("Step 9 Complete");
    }


    // write a code for when the carriage lock is z = -90, then only enable LatheCarrigae
}
