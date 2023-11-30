using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxerRig : MonoBehaviour
{
    private Transform Body;
    public Transform Right_Arm;
    public Transform Left_Arm;
    public Transform Right_Hand;
    public Transform Left_Hand;

    void Start()
    {
        Body = transform;
        Right_Hand.parent = Right_Arm;
        Left_Hand.parent = Left_Arm;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
