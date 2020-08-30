using UnityEngine;

namespace Unity.Bluetooth
{
    [CreateAssetMenu(menuName="Blatand/Bluetooth LE/Service Definition", fileName="New Service")]
    public class ServiceDefinition : ScriptableObject
    {
        public Uuid Id;
    }
}

