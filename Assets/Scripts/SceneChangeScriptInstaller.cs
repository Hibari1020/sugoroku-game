using UnityEngine;
using Zenject;

public class SceneChangeScriptInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<ISceneChangeScript>()
            .To<SceneChangeScript>()
            .FromNewComponentOnNewGameObject()
            .AsTransient();
    }
}