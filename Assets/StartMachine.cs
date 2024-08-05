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
    private int rotationSpeed = 500;
    public GameObject firstWood;
    public GameObject secondWood;
    public GameObject thirdWood;
    public GameObject fourthWood;
    public GameObject fifthWood;
    public GameObject sixthWood;
    public GameObject seventhWood;
    public GameObject eightWood;
    public GameObject ninthWood;
    public GameObject tenthWood;
    public GameObject eleventhWood;
    public GameObject firstWoodSocket;
    public GameObject spindle;
    [SerializeField] private bool isRotating = false;
    public override void CustomStart()
    {
        pushButton.GetComponent<XRSimpleInteractable>().enabled = true;
        pushButton.GetComponent<XRPokeFilter>().enabled = true;
        pushButton.GetComponent<XRPokeFollowAffordance>().enabled = true;
        pushButton.GetComponent<XRSimpleInteractable>().selectEntered.AddListener(MachineOn);
        Debug.Log("Step 6 Started");
        
    }

    

    public void Update()
    {
        if(isRotating == true)
        {
            firstWoodSocket.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            spindle.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            secondWood.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            thirdWood.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            fourthWood.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            fifthWood.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            sixthWood.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            seventhWood.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            eightWood.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            ninthWood.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            tenthWood.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            eleventhWood.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }
    }


    public void MachineOn(SelectEnterEventArgs args)
    {
        Debug.Log("Machine Started");
        //firstWood.SetActive(false);
        //firstWoodRotate.SetActive(true);
        isRotating = true;
        EventManager.onStepCompleteInvoke();
        Debug.Log("Step 6 Completed");
    }
}
