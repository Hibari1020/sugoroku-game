using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;
using UniRx.Triggers;
using Zenject;
using Cysharp.Threading.Tasks;

public class PlayerScript : MonoBehaviour, IPlayScript
{
   [SerializeField]
   private GameObject _cameraPoint;
    Animator _animator;
    private int _randomNumber;
    public int RandomNumber 
    {
        get {return _randomNumber; }
        set {_randomNumber = value; }
    }

    int _goalPos = 29;
    float speed = 3f;
    float _waitTime = 0.5f;
    IDisposable updateSubscription;

    [Inject]
    private ICubeAction _icubeAction;

    void Start()
    {
      _animator = GetComponent<Animator>();
    }

    public void DicePlayerAction()
    {
       _randomNumber = UnityEngine.Random.Range(1, 6);
       Vector3 moveDistance = new Vector3(_randomNumber, 0, 0);
       var targetPos = transform.position + moveDistance;
       if(targetPos.x > _goalPos)
       {
         targetPos.x = _goalPos;
       }
       transform.LookAt(targetPos);

       updateSubscription = this.UpdateAsObservable()
          .Subscribe(async _ => 
          {
 
             Vector3 dir = (targetPos - transform.position).normalized;
             transform.position += dir * speed * Time.deltaTime;
             _animator.SetBool("Running", true);

             if((targetPos - transform.position).magnitude < 0.1f)
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
