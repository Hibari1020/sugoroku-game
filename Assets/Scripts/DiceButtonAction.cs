using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class DiceButtonAction : MonoBehaviour
{
    [SerializeField]
    private Button _diceButton;

    [SerializeField]
    private GameObject _player;

    [Inject]
    private IDiceButtonActive _idiceActive;

    [Inject]
    private IPlayScript _iplayScript;


    // Start is called before the first frame update
    void Start()
    {
        _diceButton.onClick.AddListener(DiceAction);
    }

    public void DiceAction()
    {
       _idiceActive.ActiveFalse();
       _iplayScript.DicePlayerAction();
    }

}
