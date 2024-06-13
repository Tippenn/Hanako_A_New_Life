using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContekanBehaviour : MonoBehaviour
{
    public KeyCode Press = KeyCode.Tab;
    public Animator Animator;
    void Update()
    {
        if (Input.GetKeyDown(Press))
        {
            Animator.SetBool("Backward", false);
            Animator.SetBool("Forward", true);
        }

        if (Input.GetKeyUp(Press))
        {
            Animator.SetBool("Forward", false);
            Animator.SetBool("Backward", true);
        }
    }


}
