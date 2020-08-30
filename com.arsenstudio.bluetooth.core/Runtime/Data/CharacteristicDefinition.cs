using UnityEngine;

namespace Unity.Bluetooth
{
    [CreateAssetMenu(menuName="Blatand/Bluetooth LE/Characteristic Definition", fileName="New Characteristic")]
    public class CharacteristicDefinition : ScriptableObject
    {
        public Uuid Id;

        public ServiceDefinition ServiceDefinition;
    }
}

