using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;
using Zenject;

public class MoneyText : MonoBehaviour
{
    [SerializeField]
    private Text _nowMoneyText;
    
    [Inject]
    private INowMoney _inowMoney;

    // Start is called before the first frame update
    void Start()
    {
        this.UpdateAsObservable()
            .Subscribe(_ => 
            {
               _nowMoneyText.text = _inowMoney.NowMoneyNumber.ToString();
            })
            .AddTo(this);
    }

}
