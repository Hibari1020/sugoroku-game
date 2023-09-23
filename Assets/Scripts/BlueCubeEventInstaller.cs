using UnityEngine;
using Zenject;

public class BlueCubeEventInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject _prefab;

    public override void InstallBindings()
    {
        Container
            .Bind<IBlueCubeEvent>()
            .To<BlueCubeEvent>()
            .FromComponentOn(_prefab)
            .AsTransient();
    }
}