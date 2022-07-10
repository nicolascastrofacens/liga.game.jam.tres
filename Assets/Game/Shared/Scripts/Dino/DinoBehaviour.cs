using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoBehaviour : MonoBehaviour
{
    public float walkAmount;

    [Header("Flags")]
    public bool hasBuilding;
    public bool hasEntity;
    public bool rightStep;
    [Header("add on")]
    public DinoAnimation dinoAnimation;
    [Space]
    public BuildingInWorld BuildingInWorld;

    private void Start()
    {
        RhythmController.onCorrectHit += HandleAction;
    }

    private void HandleAction(object sender, EventArgs e)
    {
        if(!hasBuilding && !hasEntity)
        {
            Walk();
        }
        else if(hasBuilding && !hasEntity)
        {
            DestroyBuilding();
        }
    }

    private void DestroyBuilding()
    {
        hasBuilding = BuildingInWorld.BreakBuilding();
        dinoAnimation.PlayTargetAnimation("attack");
        CameraShake.instance.Shake(.3f, .2f);
    }

    private void Walk()
    {
        transform.position += new Vector3(0, 0, walkAmount);
        CameraShake.instance.Shake(.1f, .06f);
        rightStep = !rightStep;
        if (rightStep)
            dinoAnimation.PlayTargetAnimation("R_step");
        else
            dinoAnimation.PlayTargetAnimation("L_step");
    }
}
