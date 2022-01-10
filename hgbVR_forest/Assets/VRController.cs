//Jürgen Ropp

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class VRController : MonoBehaviour
{

    public float m_Sensitivity = 0.1f;
    public float m_MaxSpeed;

    public SteamVR_Action_Boolean m_MovePress = null;
    public SteamVR_Action_Vector2 m_MoveValue = null;

    private float m_Speed = 0.0f;

    private CharacterController m_CharacterController = null;
    private Transform m_CameraRig = null;
    private Transform m_Head = null;

    private void Awake()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }

    private void Start()
    {
        m_CameraRig = SteamVR_Render.Top().origin;

    }

    private void Update()
    {
        HandleHead();
        CalculateMovement();
        HandleHeight();
    }

    private void HandleHead()
    {
        //Store current
        Vector3 oldPosition = m_CameraRig.position;
        Quaternion oldRotation = m_CameraRig.rotation;

        //Rotation
        //transform.eulerAngles = new Vector3(0.0f, m_Head.rotation.eulerAngles.y, 0.0f);

        //Restore
        m_CameraRig.position = oldPosition;
        m_CameraRig.rotation = oldRotation;


    }

    private void CalculateMovement()
    {

        //movement orientation
        Vector3 orientationEuler = new Vector3(0, transform.eulerAngles.y, 0);
        Quaternion orientation = Quaternion.Euler(orientationEuler);
        Vector3 movement = Vector3.zero;

        //if not moving
        //if (m_MovePress.GetStateUp(SteamVR_Input_Sources.Any));
        m_Speed = 0;


        //if button pressed
        if(m_MovePress.state)
        {
            //add, clamp
            m_Speed += m_MoveValue.axis.y * m_Sensitivity;
            m_Speed = Mathf.Clamp(m_Speed, -m_MaxSpeed, m_MaxSpeed);

            //orientation
            movement += orientation * (m_Speed * Vector3.forward * Time.deltaTime);



        }

        //Apply
        m_CharacterController.Move(movement);




    }

    private void HandleHeight()
    {
        float headHeight = Mathf.Clamp(m_Head.localPosition.y, 1, 2);


    }


}
