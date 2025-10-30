using UnityEngine;
using WiimoteApi;

public class QuickSetup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WiimoteManager.FindWiimotes();
        for(int i = 0; i < WiimoteManager.Wiimotes.Count; i++)
        {
            Wiimote mote = WiimoteManager.Wiimotes[i];
            mote.SendDataReportMode(InputDataType.REPORT_BUTTONS_ACCEL);
            mote.SendPlayerLED(i == 0, i == 1, i == 2, i == 3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
