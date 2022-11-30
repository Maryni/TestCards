using UnityEngine;
using Zenject;

public class AudioControllerInstaller : MonoInstaller
{
    [SerializeField] private AudioController audioController;
    public override void InstallBindings()
    {
        Container.BindInstance(audioController);
    }
}