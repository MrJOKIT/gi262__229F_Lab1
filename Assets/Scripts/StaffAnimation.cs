using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffAnimation : MonoBehaviour
{
    private Animator anim;
    private Staff staff;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        staff = GetComponent<Staff>();
    }

    private void Update()
    {
        if (staff.State == UniteState.Idle)
        {
            DisableAll();
            anim.SetBool("isIdle",true);
        }
        else if (staff.State == UniteState.Walk)
        {
            DisableAll();
            anim.SetBool("isWalk",true);
        }
        
    }

    private void DisableAll()
    {
        anim.SetBool("isIdle",false);
        anim.SetBool("isWalk",false);
    }
}
