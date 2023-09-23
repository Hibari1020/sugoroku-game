using UnityEngine;
using Zenject;

public class NameSetScriptInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject _nameSetObject;

    public override void InstallBindings()
    {
       Container
           .Bind<INameSetScript>()
           .To<NameSetScript>()
           .FromComponentOn(_nameSetObject)
           .AsTransient();
    }
}