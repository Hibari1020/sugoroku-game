using UnityEngine;
using Zenject;

public class RedCubeEventInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject _prefab;

    public override void InstallBindings()
    {
        Container
            .Bind<IRedCubeEvent>()
            .To<RedCubeEvent>()
            .FromComponentOn(_prefab)
            .AsTransient();
    }
}