using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class inputTest : MonoBehaviour { 

    public SteamVR_ActionSet m_ActionSet;

    public SteamVR_Action_Boolean m_booleanAction;
    public SteamVR_Action_Boolean m_TouchPosition;

    //if(m_booleanAction[SteamVR_Input_Sources.RightHand].stateDown)


    // Start is called before the first frame update
    void Start()
    {
        m_ActionSet.Activate(SteamVR_Input_Sources.Any, 0, true);
    }

    private void Awake()
    {
        m_booleanAction = SteamVR_Actions._default.GrabPinch;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_booleanAction[SteamVR_Input_Sources.RightHand].stateDown)
        {
            print("buttonDown");
        }
    }
}
