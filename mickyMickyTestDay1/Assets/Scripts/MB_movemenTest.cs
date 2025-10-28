using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MB_movemenTest : MonoBehaviour
{

    public float speed = 3;

    void Start()
    {

    }

    void Update()
    {
        Vector3 movementTest = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        transform.Translate(movementTest * speed * Time.deltaTime);

    }
}
