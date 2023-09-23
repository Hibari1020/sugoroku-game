using UnityEngine;
using Zenject;

public class CubeActionInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<ICubeAction>()
            .To<CubeAction>()
            .FromNewComponentOnNewGameObject()
            .AsTransient();
    }
}