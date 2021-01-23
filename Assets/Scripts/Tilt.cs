using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    [SerializeField] private float tiltAmount = 10f;
    [SerializeField] private float tiltFactor = 0f;
    [SerializeField] private float tiltFactorAmount = 0.5f;

    float input = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) input = Input.mousePosition.x > Screen.width / 2 ? -1f : 1f;
        else input = 0f;

        transform.Rotate(Vector3.forward, (input + tiltFactor) * Time.deltaTime * tiltAmount);

        if((tiltFactor * tiltFactor) > 0)
        {
            tiltFactor -= (tiltFactor > 0) ? Time.deltaTime : -Time.deltaTime;
        }
    }

    public void StartTilt(Vector3 hitPosition)
    {
        tiltFactor = ((hitPosition.x > transform.position.x) ? -1 : 1) * tiltFactorAmount;
    }
}
