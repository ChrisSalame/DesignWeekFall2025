using System.Net.NetworkInformation;
using UnityEngine;
using WiimoteApi;

public class AccelBoatMove : MonoBehaviour
{
    Wiimote mote;
    public GameObject obj;
    public Rigidbody rb;
    public int multiplier;

    public int o;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mote = WiimoteManager.Wiimotes[o];

        if (Input.GetKeyDown(KeyCode.O))
        {
            mote.SendDataReportMode(InputDataType.REPORT_BUTTONS_ACCEL);
            mote.SendPlayerLED(true, true, (o == 0), false);
        }

        Debug.Log(mote.Accel.accel[0] + " " + mote.Accel.accel[1] + " " + mote.Accel.accel[1]);
        obj.SetActive(mote.Accel.accel[2] > 615);

        if (mote.Accel.accel[1] > 610)
        {
            rb.AddForce(transform.forward * Time.deltaTime * 300, ForceMode.Acceleration);
            transform.Rotate(0, 60 * multiplier * Time.deltaTime, 0);
        }
        else
        {
            rb.linearVelocity *= 0.995f;
        }

        if (mote.Accel.accel[0] < 460)
        {
            multiplier = 1;
        }
        else if (mote.Accel.accel[0] > 550)
        {
            multiplier = -1;
        }

        //mote.SendDataReportMode(InputDataType.REPORT_BUTTONS_ACCEL);    
    }
}
