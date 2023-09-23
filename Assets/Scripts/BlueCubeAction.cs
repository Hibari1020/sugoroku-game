using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class BlueCubeAction : MonoBehaviour, IBlueCubeAction
{
    Animator _animator;
    List<int> _eventNumbers = new List<int>();

    [Inject]
    private IBlueCubeEvent _iblueEvent;

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

    public void BlueAction()
    {
        _animator.SetTrigger("Jump");
        _idiceActive.ActiveTrue();
        
        int randomIndex = UnityEngine.Random.Range(0, _eventNumbers.Count);
        int selectedEventNumber = _eventNumbers[randomIndex];
        _eventNumbers.RemoveAt(randomIndex);
        
        string methodName = "BlueEvent" + selectedEventNumber;
        var methodInfo = _iblueEvent.GetType().GetMethod(methodName);
        if(methodInfo != null)
        {
            methodInfo.Invoke(_iblueEvent, null);
        }
    }
}
