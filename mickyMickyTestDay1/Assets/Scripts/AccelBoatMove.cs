using System.Net.NetworkInformation;
using UnityEngine;
using WiimoteApi;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;

public class AccelBoatMove : MonoBehaviour
{
    Wiimote mote;
    public GameObject paddle;
    public Rigidbody rb;
    private int multiplier;
    [SerializeField]
    private float rumbleTimer, prevRumbleTimer;
    private Quaternion baseRotLeft, baseRotRight;
    public AudioSource audSou;

    public int chosenRemote;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        baseRotRight = paddle.transform.parent.localRotation;
        paddle.transform.parent.Rotate(0, -90, 0);
        baseRotLeft = paddle.transform.parent.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        mote = WiimoteManager.Wiimotes[chosenRemote];

        paddle.SetActive(rumbleTimer > 0);

        if (mote.Accel.accel[1] > 610)
        {
            rb.AddForce(transform.forward * Time.deltaTime * 300, ForceMode.Acceleration);
            transform.Rotate(0, 60 * multiplier * Time.deltaTime, 0);
            paddle.transform.parent.Rotate(0, 150 * -multiplier * Time.deltaTime, 0);
            rumbleTimer = 0.1f;
        }
        else
        {
            rb.linearVelocity *= 0.993f;
        }

        if (mote.Accel.accel[0] < 460)
        {
            multiplier = 1;
        }
        else if (mote.Accel.accel[0] > 550)
        {
            multiplier = -1;
        }

        if (rumbleTimer > 0)
        {
            rumbleTimer -= Time.deltaTime;

            if (prevRumbleTimer < 0)
            {
                mote.RumbleOn = true;
                audSou.Play();
                mote.SendDataReportMode(InputDataType.REPORT_BUTTONS_ACCEL);

                ResetPaddlePos();
            }
        }
        if (rumbleTimer < 0 && prevRumbleTimer > 0)
        {
            mote.RumbleOn = false;
            mote.SendDataReportMode(InputDataType.REPORT_BUTTONS_ACCEL);
            ResetPaddlePos();
        }
        prevRumbleTimer = rumbleTimer;
        
    }

    private void ResetPaddlePos()
    {
        if (multiplier == 1)
        {
            paddle.transform.parent.localRotation = baseRotLeft;
        }
        else
        {
            paddle.transform.parent.localRotation = baseRotRight;
        }
    }
}
