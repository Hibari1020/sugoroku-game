using UnityEngine;
using Zenject;

public class GreenCubeActionInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject _gameObject;

    public override void InstallBindings()
    {
        Container
            .Bind<IGreenCubeAction>()
            .To<GreenCubeAction>()
            .FromComponentOn(_gameObject)
            .AsSingle();
    }
}