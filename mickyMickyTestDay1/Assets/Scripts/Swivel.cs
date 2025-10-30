using UnityEngine;
using WiimoteApi;

public class Swivel : MonoBehaviour
{
    Wiimote mote;
    public int chosenRemote;
    private bool firstFrame = true;
    public GameObject pointLocation;
    public Vector3 pointStart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pointStart = transform.localPosition;
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
        pointLocation.transform.position = new Vector3(-(pointStart.x + mote.Accel.accel[0] - 500) / 20, 0.45f, -15);

        transform.LookAt(pointLocation.transform.position);
    }
}
