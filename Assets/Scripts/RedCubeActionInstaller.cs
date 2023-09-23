using UnityEngine;
using Zenject;

public class RedCubeActionInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject _player;

    public override void InstallBindings()
    {
        Container
            .Bind<IRedCubeAction>()
            .To<RedCubeAction>()
            .FromComponentOn(_player)
            .AsSingle();
    }
}