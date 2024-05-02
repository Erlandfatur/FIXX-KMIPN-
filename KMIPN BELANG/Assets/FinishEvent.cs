using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishEvent : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other) {
        RadioInventory radioInventory = other.GetComponent<RadioInventory>();
    }
}
