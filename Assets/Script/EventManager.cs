using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action onStepComplete;

    public static void onStepCompleteInvoke()
    {
        onStepComplete?.Invoke();
    }
    
}
