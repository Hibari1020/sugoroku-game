using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class BlueCubeEvent : MonoBehaviour, IBlueCubeEvent
{ 
   [SerializeField]
   private Text _eventText;

   [Inject]
   private INowMoney _inowMoney;
   
   public void BlueEvent1()
   {
     _eventText.text = "バイトに励むため5万円もらう";
     _inowMoney.NowMoneyNumber += 50000;
   }

   public void BlueEvent2()
   {
     _eventText.text = "誕生日に図書カードをもらうため5000円もらう";
     _inowMoney.NowMoneyNumber += 5000;
   }

   public void BlueEvent3()
   {
     _eventText.text = "自分で作ったゲームが売れるため1万円もらう";
     _inowMoney.NowMoneyNumber += 10000;
   }

   public void BlueEvent4()
   {
     _eventText.text = "宝くじにあたるため30万円もらう";
     _inowMoney.NowMoneyNumber += 300000;
   }

   public void BlueEvent5()
   {
     _eventText.text = "パチンコでビギナーズラックをするため5万円もらう";
     _inowMoney.NowMoneyNumber += 50000;
   }

   public void BlueEvent6()
   {
     _eventText.text = "株で短期的な利益を得るため10万円もらう";
     _inowMoney.NowMoneyNumber += 100000;
   }

   public void BlueEvent7()
   {
     _eventText.text = "Youtubeがバズるため50万円もらう";
     _inowMoney.NowMoneyNumber += 500000;
   }

   public void BlueEvent8()
   {
     _eventText.text = "競馬が当たるため10万円もらう";
     _inowMoney.NowMoneyNumber += 100000;
   }

   public void BlueEvent9()
   {
     _eventText.text = "500円玉を拾う";
     _inowMoney.NowMoneyNumber += 500;
   }

   public void BlueEvent10()
   {
     _eventText.text = "ボーナスが入るため100万円もらう";
     _inowMoney.NowMoneyNumber += 1000000;
   }
}
