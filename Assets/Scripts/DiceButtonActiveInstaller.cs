using UnityEngine;
using Zenject;

public class DiceButtonActiveInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject _prefab;

    public override void InstallBindings()
    {
        Container
            .Bind<IDiceButtonActive>()
            .To<DiceButtonActive>()
            .FromComponentOn(_prefab)
            .AsSingle();
    }
}