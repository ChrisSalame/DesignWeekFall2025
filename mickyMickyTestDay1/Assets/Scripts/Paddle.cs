using TMPro;
using UnityEngine;
using WiimoteApi;
using static WiimoteDemo;

public class Paddle : MonoBehaviour
{
    public Quaternion initial_rotation;

    private Wiimote wiimote;

    private Vector3 wmpOffset = Vector3.zero;

    public WiimoteModel model;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        wiimote = WiimoteManager.Wiimotes[0];
        wiimote.RequestIdentifyWiiMotionPlus();
        wiimote.ActivateWiiMotionPlus();
    }

    // Update is called once per frame
    void Update()
    {
        if (!WiimoteManager.HasWiimote()) { return; }

        wiimote = WiimoteManager.Wiimotes[0];

        Vector3 offset = new Vector3(-wiimote.MotionPlus.PitchSpeed, wiimote.MotionPlus.YawSpeed, wiimote.MotionPlus.RollSpeed) / 95f;

        wmpOffset += offset;

        model.rot.Rotate(offset, Space.Self);



    }
}
