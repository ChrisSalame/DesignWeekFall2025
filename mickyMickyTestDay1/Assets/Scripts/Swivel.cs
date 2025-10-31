using UnityEngine;
using WiimoteApi;

public class Swivel : MonoBehaviour
{
    Wiimote mote;
    public int chosenRemote;
    private bool firstFrame = true;
    public int offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mote = WiimoteManager.Wiimotes[chosenRemote];
        if (firstFrame)
        {
            mote.Accel.CalibrateAccel(AccelCalibrationStep.LEFT_SIDE_UP);
            firstFrame = false;
        }

        transform.localEulerAngles = new Vector3(0, (-(mote.Accel.accel[0] - 500)) * Mathf.Rad2Deg / 150 + offset, 0);
    }
}
