using BepInEx;
using BepInEx.Configuration;
using KitchenLib;
using System.Reflection;
using Cinemachine;

namespace FirstPersonMod
{
    // guid must be unique and is recommended to be in reverse domain name notation
    // mod name that is displayed to the player and listed in the mods menu
    // mod version must follow semver e.g. "1.2.3"
    [BepInPlugin("alexzander700.FirstPerson", "FirstPersonMod", "0.1.0")]
    [BepInProcess("PlateUp.exe")]
    [BepInDependency("kitchenmods.kitchenlib")]
    public class DisableCinemachine : BaseUnityPlugin
    {
        private void Awake()
        {
            // Disable all Cinemachine components
            var cinemachineComponents = FindObjectsOfType<CinemachineBrain>();
            foreach (var component in cinemachineComponents)
            {
                component.enabled = false;
            }
        }
    }



}
