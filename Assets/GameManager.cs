using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GenericSteps[] steps; // calling out each step scripts attached to GameObject
    private int totalSteps;
    private int currentStepIndex = 0;
    void Start()
    {
        totalSteps = steps.Length;
        steps[currentStepIndex].CustomStart();
        EventManager.onStepComplete += NextStep; // here, GameManager subscribs the onStepComplete event and start the NextStep Method. (once the onStepCompleteInvoke method invokes the onStepComplete event, the subscribed method, NextStep, will be called)
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
