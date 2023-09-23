using UnityEngine;
using Zenject;

public class BlueCubeActionInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject _player;

    public override void InstallBindings()
    {
       Container
           .Bind<IBlueCubeAction>()
           .To<BlueCubeAction>()
           .FromComponentOn(_player)
           .AsSingle();
    }
}