using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using UnityEngine.UI;
using System;
using Cysharp.Threading.Tasks;
using Zenject;

public class YellowCubeAction : MonoBehaviour, IYellowCubeAction
{
    [SerializeField]
    private GameObject _cameraPoint;
    [SerializeField]
    private Text _eventText;
    Animator _animator;
    IDisposable updateSubscription;
    float _speed = 3f;
    float _waitTime = 0.5f;
    float _startPoint = 1f;
    float _arriveDistance = 0.1f;

    [Inject]
    private ICubeAction _icubeAction;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void YellowEvent()
    {
       int _randomNumber = UnityEngine.Random.Range(-3,-1);
        Vector3 moveDistance = new Vector3(_randomNumber, 0, 0);
        int _randomNumber2 = Mathf.Abs(_randomNumber);
        _eventText.text = _randomNumber2.ToString() + "マス戻る";
        var targetPos = transform.position + moveDistance;
        if(targetPos.x < _startPoint)
        {
            targetPos.x = _startPoint;
        }
        transform.LookAt(targetPos);
        
        updateSubscription = this.UpdateAsObservable()
                                 .Subscribe(async _ => 
                                 {
                                      Vector3 dir = (targetPos - transform.position).normalized;
                                      transform.position += dir * _speed * Time.deltaTime;
                                      _animator.SetBool("Running", true);
                                      
                                      if((targetPos - transform.position).magnitude < _arriveDistance)
                                      {
                                         transform.position = targetPos;
                                         transform.LookAt(_cameraPoint.transform.position);
                                         _animator.SetBool("Running", false);
                                         updateSubscription.Dispose();
                                         await UniTask.Delay(TimeSpan.FromSeconds(_waitTime));
                                         _icubeAction.GetAction(transform.position);
                                      }
                                 }); 
        
    }
}
