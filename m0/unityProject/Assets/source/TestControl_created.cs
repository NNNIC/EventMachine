//  psggConverterLib.dll converted from TestControl.xlsx. 
using System;
using UnityEngine;
public partial class TestControl : StateManager {

    public override void Start()
    {
        Goto(S_START);
    }
    public override bool IsEnd()
    {
        return CheckState(S_END);
    }



    /*
        S_START
    */
    void S_START(bool bFirst)
    {
        if (bFirst)
        {
        }
        if (!HasNextState())
        {
            SetNextState(S_CHECK_EVENT);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_END
    */
    void S_END(bool bFirst)
    {
        if (bFirst)
        {
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_CHECK_EVENT
    */
    void S_CHECK_EVENT(bool bFirst)
    {
        if (bFirst)
        {
        }
        br_BTN_A(S_BTN_A);
        br_BTN_B(S_BTN_B);
        br_BTN_C(S_BTN_C);
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_BTN_A
    */
    void S_BTN_A(bool bFirst)
    {
        if (bFirst)
        {
            Debug.Log("Pressed Button A");
        }
        if (!HasNextState())
        {
            SetNextState(S_CHECK_EVENT);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_BTN_B
    */
    void S_BTN_B(bool bFirst)
    {
        if (bFirst)
        {
            Debug.Log("Pressed Button B");
        }
        if (!HasNextState())
        {
            SetNextState(S_CHECK_EVENT);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_BTN_C
    */
    void S_BTN_C(bool bFirst)
    {
        if (bFirst)
        {
            Debug.Log("Pressed Button C");
        }
        if (!HasNextState())
        {
            SetNextState(S_CHECK_EVENT);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }

}

