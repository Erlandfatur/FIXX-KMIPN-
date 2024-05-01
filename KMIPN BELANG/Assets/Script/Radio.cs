using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        RadioInventory radioInventory = other.GetComponent<RadioInventory>();

        if (radioInventory != null)
        {
            radioInventory.RadioCollected();
            gameObject.SetActive(false);
        }
    }
}
