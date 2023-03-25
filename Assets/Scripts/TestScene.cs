using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScene : MonoBehaviour
{
    public Staff staff;

    public void ButtonIdle()
    {
        staff.State = UniteState.Idle;
    }

    public void ButtonWalk()
    {
        staff.State = UniteState.Walk;
    }
}
