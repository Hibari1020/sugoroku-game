using UnityEngine;
using Zenject;

public class GoalCubeActionInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject _prefab;

    public override void InstallBindings()
    {
        Container
            .Bind<IGoalCubeAction>()
            .To<GoalCubeAction>()
            .FromComponentOn(_prefab)
            .AsSingle();
    }
}