using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericSteps : MonoBehaviour
{
    [SerializeField] private int steps;

    public abstract void CustomStart(); // since we cannot call start method, we create custom start method to be called in Game Manager
}
