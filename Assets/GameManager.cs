using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GenericSteps[] steps;
    private int totalSteps;
    private int currentStepIndex = 0;
    void Start()
    {
        totalSteps = steps.Length;
        steps[currentStepIndex].CustomStart();
        EventManager.onStepComplete += NextStep;
    }

    void NextStep()
    {
        currentStepIndex++;
        if(currentStepIndex < totalSteps)
        {
            steps[currentStepIndex].CustomStart();
        }
    }

    void OnDestroy()
    {
        EventManager.onStepComplete -= NextStep;
    }
}
