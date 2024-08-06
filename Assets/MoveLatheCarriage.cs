using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MoveLatheCarriage : GenericSteps
{
    public GameObject latheCarriage;
    public GameObject latheCarriageGreenLoc;



    public override void CustomStart()
    {
        latheCarriage.GetComponent<XRGrabInteractable>().enabled = true;
        latheCarriageGreenLoc.SetActive(true);
        Debug.Log("Step 10 Started");
    }
}
