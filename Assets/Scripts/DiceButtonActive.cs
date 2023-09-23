using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceButtonActive : MonoBehaviour, IDiceButtonActive
{
    [SerializeField]
    private Button _diceButton;

    public void ActiveTrue()
    {
        _diceButton.gameObject.SetActive(true);
    }

    public void ActiveFalse()
    {
        _diceButton.gameObject.SetActive(false);
    }

}
