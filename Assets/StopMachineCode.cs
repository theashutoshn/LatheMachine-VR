using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMachineCode : MonoBehaviour
{
    private StartMachine startMachine;
    private bool stopMachine;
    private void Start()
    {
        startMachine = GetComponent<StartMachine>();
        stopMachine = startMachine.isRotating;
    }
    public void NoRotateWoood()
    {
        stopMachine = false;
        Debug.Log("Step 8 Completed");
        EventManager.onStepCompleteInvoke();
    }
}
