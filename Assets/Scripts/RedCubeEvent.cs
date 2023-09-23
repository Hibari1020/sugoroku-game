using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class RedCubeEvent : MonoBehaviour, IRedCubeEvent
{
    [SerializeField]
    private Text _eventText;

    [Inject]
    private INowMoney _inowMoney;

    public void RedEvent1()
    {
        _inowMoney.NowMoneyNumber -= 50000;
        _eventText.text = "家族旅行に行くため5万円払う";
    }

    public void RedEvent2()
    {
        _inowMoney.NowMoneyNumber -= 50000;
        _eventText.text = "友達と旅行に行くため5万円払う";
    }

    public void RedEvent3()
    {
        _inowMoney.NowMoneyNumber -= 300000;
        _eventText.text = "免許合宿に行くため30万円払う";
    }

    public void RedEvent4()
    {
        _inowMoney.NowMoneyNumber -= 30000;
        _eventText.text = "すりにあったため3万円失う";
    }

    public void RedEvent5()
    {
        _inowMoney.NowMoneyNumber -= 5000;
        _eventText.text = "趣味のゴルフに行くため5000円払う";
    }

    public void RedEvent6()
    {
        _inowMoney.NowMoneyNumber -= 20000;
        _eventText.text = "親戚にお年玉をあげるため2万円払う";
    }

    public void RedEvent7()
    {
        _inowMoney.NowMoneyNumber -= 100000;
        _eventText.text = "階段から落ちて入院するため10万円払う";
    }

    public void RedEvent8()
    {
        _inowMoney.NowMoneyNumber -= 50000;
        _eventText.text = "新しいスマホを買うため5万円払う";
    }

    public void RedEvent9()
    {
        _inowMoney.NowMoneyNumber -= 30000;
        _eventText.text = "ショッピングモールで散財するため3万円払う";
    }

    public void RedEvent10()
    {
        _inowMoney.NowMoneyNumber -= 20000;
        _eventText.text = "サブスクの解約忘れで2万円払う";
    }
}
