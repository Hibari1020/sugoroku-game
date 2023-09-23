using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class GoalCubeAction : MonoBehaviour, IGoalCubeAction
{
    [SerializeField]
    private GameObject _userNameObject;
    [SerializeField]
    private GameObject _falseObject;
    [SerializeField]
    private GameObject _activeObject;

    [Inject]
    private INowMoney _inowMoney;

    public void GoalEvent()
    {
      _userNameObject.SetActive(false);
      _falseObject.SetActive(false);
      _activeObject.SetActive(true);
      naichilab.RankingLoader.Instance.SendScoreAndShowRanking(_inowMoney.NowMoneyNumber);
    }

}
