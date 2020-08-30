using UnityEngine;

namespace Unity.Bluetooth.Android
{
    /// <summary>
    /// This abstract class is used to implement BluetoothGatt callbacks. 
    /// </summary>
    public class DeprecatedScanCallback : AndroidJavaProxy
    {

        public DeprecatedScanCallback() : base("com.blatand.DeprecatedScanCallback") { }

        public virtual void OnLeScan(AndroidJavaObject androidDevice, int rssi)
        {
                
        }
    }
}

