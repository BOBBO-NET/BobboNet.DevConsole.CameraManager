using UnityEngine;
using Zenject;

namespace BobboNet.DevConsole.CameraManager
{
    [CreateAssetMenu(fileName = "CameraManagerConsoleCommandInstaller", menuName = "Installers/CameraManagerConsoleCommandInstaller")]
    public class CameraManagerConsoleCommandInstaller : ScriptableObjectInstaller<CameraManagerConsoleCommandInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<DevConsoleCommandBase>().To<ConsoleCommands.GetFOV>().AsSingle();
        }
    }
}