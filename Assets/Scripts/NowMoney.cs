using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NowMoney : MonoBehaviour, INowMoney
{
   private int _nowMoneyNumber;

   public int NowMoneyNumber 
   {
     get 
     { 
        return _nowMoneyNumber;
     }
     set 
     {
        _nowMoneyNumber = value;
     }
   }

   int _startMoneyNumber = 0;

   void Start()
   {
      _nowMoneyNumber = _startMoneyNumber;
   }
}
