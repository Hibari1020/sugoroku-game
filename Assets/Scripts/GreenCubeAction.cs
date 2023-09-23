using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UniRx;
using UniRx.Triggers;
using Cysharp.Threading.Tasks;
using Zenject;

public class GreenCubeAction : MonoBehaviour, IGreenCubeAction
{
    [SerializeField]
    private Text _eventText;
    [SerializeField]
    private GameObject _cameraPoint;
    Animator _animator;
    float _speed = 3f;
    float _waitTime = 0.5f;
    float _goalPoint = 29f;
    float _arriveDistance = 0.1f;
    IDisposable updateSubscription;

    [Inject]
    private ICubeAction _icubeAction;

    // Start is called before the first frame update
    void Start()
    {
       _animator = GetComponent<Animator>(); 
    }

    public void GreenEvent()
    {
       int _randomNumber = UnityEngine.Random.Range(1,3);
        Vector3 moveDistance = new Vector3(_randomNumber, 0, 0);
        _eventText.text = _randomNumber.ToString() + "マス進む";
        var targetPos = transform.position + moveDistance;
        if(targetPos.x > _goalPoint)
        {
            targetPos.x = _goalPoint;
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
