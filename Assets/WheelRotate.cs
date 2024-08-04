using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

using Unity.Mathematics;

public class WheelRotate : GenericSteps
{
    public GameObject wheel;
    private XRGrabInteractable wheelGrab;
    public GameObject mover;
    private Quaternion initialRotation;
    public override void CustomStart()
    {
        //wheelGrab.GetComponent<XRGrabInteractable>().enabled = true;
        Debug.Log("Step 5 Started");
    }


    public override void CustomUpdate()
    {
        

        Debug.Log("Wheel X Angle: " + wheel.transform.rotation.eulerAngles.x);
        //if(wheel.transform.rotation.eulerAngles.x > 0)
        Vector3 lastPos = new Vector3(-0.18f, 1.8616f, -0.0029f);
        LeanTween.moveLocal(mover, lastPos, 10f);
    }
}
