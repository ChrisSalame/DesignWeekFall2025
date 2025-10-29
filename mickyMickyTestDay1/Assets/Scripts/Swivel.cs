using UnityEngine;
using WiimoteApi;

public class Swivel : MonoBehaviour
{
    Wiimote mote;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            mote = WiimoteManager.Wiimotes[1];
            mote.SendPlayerLED(true, true, true, false);

        }
        
    }
}
