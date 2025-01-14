using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateText : MonoBehaviour
{
    public InterfaceVariable variableToUpdate;

    private TMP_Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(variableToUpdate)
        {
            case InterfaceVariable.COINS:
                textComponent.text = "Monedas: " + GameManager.instance.GetCoins();
                break;
            case InterfaceVariable.TIME:
                break;
        }
    }
}
