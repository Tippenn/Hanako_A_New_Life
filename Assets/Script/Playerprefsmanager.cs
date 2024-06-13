using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerprefsmanager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PlayerPrefs.DeleteKey("pernah");
            Debug.Log("sudah delete boss");
        }
    }
}
