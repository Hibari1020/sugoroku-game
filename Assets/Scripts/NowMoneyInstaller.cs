using UnityEngine;
using Zenject;

public class NowMoneyInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject _prefab;
    
    public override void InstallBindings()
    {
        Container
            .Bind<INowMoney>()
            .To<NowMoney>()
            .FromComponentOn(_prefab)
            .AsSingle();
    }
}