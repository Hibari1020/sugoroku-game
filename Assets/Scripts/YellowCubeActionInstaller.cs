using UnityEngine;
using Zenject;

public class YellowCubeActionInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject _player;

    public override void InstallBindings()
    {
       Container
           .Bind<IYellowCubeAction>()
           .To<YellowCubeAction>()
           .FromComponentOn(_player)
           .AsSingle();
    }
}