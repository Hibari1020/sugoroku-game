using UnityEngine;
using Zenject;

public class PlayScriptInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject _player;

    public override void InstallBindings()
    {
        Container
            .Bind<IPlayScript>()
            .To<PlayerScript>()
            .FromComponentOn(_player)
            .AsSingle();
    }
}