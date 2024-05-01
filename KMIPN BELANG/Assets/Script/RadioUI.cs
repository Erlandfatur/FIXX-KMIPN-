using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RadioUI : MonoBehaviour
{
    private TextMeshProUGUI radioText;

    // Start is called before the first frame update
    void Start()
    {
        radioText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateRadioText(RadioInventory radioInventory)
    {
        radioText.text = radioInventory.NumberOfRadio.ToString();
    }
}
