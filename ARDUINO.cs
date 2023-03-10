using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class ARDUINO : MonoBehaviour
{
    SerialPort stream;

    // Start is called before the first frame update
    void Start()
    {
        stream = new SerialPort("COM5", 9600);
        stream.Open();
        Debug.Log("Stream opened");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            stream.Write("gay gay gya gay");
            Debug.Log("Message sent");
        }

        if (Input.GetKeyDown("x"))
        {
            stream.Close();
            Debug.Log("Stream closed");
        }
    }
}
