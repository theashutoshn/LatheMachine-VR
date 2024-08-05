using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action onStepComplete;

    public static void onStepCompleteInvoke() // method to invoke onStepComplete event, notifying others
    {
        onStepComplete?.Invoke();
    }
    
}
