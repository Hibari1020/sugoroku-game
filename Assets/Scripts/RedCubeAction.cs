using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class RedCubeAction : MonoBehaviour, IRedCubeAction
{
    Animator _animator;
    List<int> _eventNumbers = new List<int>();

    [Inject]
    private IRedCubeEvent _iredEvent;

    [Inject]
    private IDiceButtonActive _idiceActive;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        

        for (int i = 1; i <= 10; i++)
        {
            _eventNumbers.Add(i);
        }
    }

    public void RedAction()
    {
        _animator.SetTrigger("Damaged");
        _idiceActive.ActiveTrue();
        
        int randomIndex = UnityEngine.Random.Range(0, _eventNumbers.Count);
        int selectedEventNumber = _eventNumbers[randomIndex];
        _eventNumbers.RemoveAt(randomIndex);
        
        string methodName = "RedEvent" + selectedEventNumber;
        var methodInfo = _iredEvent.GetType().GetMethod(methodName);
        if(methodInfo != null)
        {
            methodInfo.Invoke(_iredEvent, null);
        }
    }
}
