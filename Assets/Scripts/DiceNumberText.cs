using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;
using Zenject;

public class DiceNumberText : MonoBehaviour
{
    [SerializeField]
    private Text _diceNumberText;

    [Inject]
    private IPlayScript _iplayScript;

    // Start is called before the first frame update
    void Start()
    {

       this.UpdateAsObservable()
           .Subscribe(_ => 
           {
             _diceNumberText.text = _iplayScript.RandomNumber.ToString();
           })
           .AddTo(this);
    }
}
