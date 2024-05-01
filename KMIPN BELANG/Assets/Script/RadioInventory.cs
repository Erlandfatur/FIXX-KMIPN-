using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RadioInventory : MonoBehaviour
{
    public int NumberOfRadio { get; private set; }

    public UnityEvent<RadioInventory> OnRadioCollected;

    public void RadioCollected()
    {
        NumberOfRadio++;
        OnRadioCollected.Invoke(this);
    }
}
