using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Zenject;

public class CubeAction : MonoBehaviour, ICubeAction
{
    private Dictionary<Vector3, Action> _cubeActionPairs = new Dictionary<Vector3, Action>();

    public Dictionary<Vector3, Action> CubeActionPairs
    {
        get { return _cubeActionPairs; }
        set { _cubeActionPairs = value; }
    }

    int _goalPos = 29;
    float _playerYPos = 0.5f;
    
    [Inject]
    private IGreenCubeAction _igreenCubeAction;

    [Inject]
    private IYellowCubeAction _iyellowCubeAction;

    [Inject]
    private IBlueCubeAction _iblueCubeAction;

    [Inject]
    private IRedCubeAction _iredCubeAction;

    [Inject]
    private IGoalCubeAction _igoalCubeAction;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 6; i++)
        {
            _cubeActionPairs.Add(new Vector3(1 + 4 * i, _playerYPos, 0), () => 
            {
                _iredCubeAction.RedAction();
            });

            _cubeActionPairs.Add(new Vector3(2 + 4 * i, _playerYPos, 0), () => 
            {
                _iblueCubeAction.BlueAction();
            });

            _cubeActionPairs.Add(new Vector3(3 + 4 * i, _playerYPos, 0), () =>
            {
                _igreenCubeAction.GreenEvent();
            });

            _cubeActionPairs.Add(new Vector3(4 + 4 * i, _playerYPos, 0), () => 
            {
                _iyellowCubeAction.YellowEvent();
            });
        }
        
        _cubeActionPairs.Add(new Vector3(_goalPos, _playerYPos, 0), () => 
        {
            _igoalCubeAction.GoalEvent();
        });

    }

    public void GetAction(Vector3 pos)
    {

        if(CubeActionPairs.TryGetValue(pos, out Action getAction))
        {
            getAction();
        }
        else 
        {
            Debug.Log("Key is not found");
        }
    }


}
