using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class StartMachine : GenericSteps
{
    public GameObject pushButton;
    private int rotationSpeed = 200;
    public GameObject firstWood;
    public GameObject firstWoodRotate;
    public GameObject spindle;
    [SerializeField] private bool isRotating = false;
    public override void CustomStart()
    {
        pushButton.GetComponent<XRSimpleInteractable>().enabled = true;
        pushButton.GetComponent<XRPokeFilter>().enabled = true;
        pushButton.GetComponent<XRPokeFollowAffordance>().enabled = true;
        pushButton.GetComponent<XRSimpleInteractable>().selectEntered.AddListener(MachineOn);
        
    }

    

    public void Update()
    {
        if(isRotating == true)
        {
            firstWoodRotate.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            spindle.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
    }


    public void MachineOn(SelectEnterEventArgs args)
    {
        Debug.Log("Machine Started");
        firstWood.SetActive(false);
        firstWoodRotate.SetActive(true);
        isRotating = true;
    }
}
