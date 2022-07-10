using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythmNeedle : MonoBehaviour
{
    public RhythmController controller;
    public Transform GFX;


    private void OnTriggerEnter(Collider other)
    {
        controller.NeedleOnPosition = true;
        controller.currentNote = other.transform.parent.gameObject;
        GFX.localScale *= 1.1f;
    }

    private void OnTriggerExit(Collider other)
    {
        controller.NeedleOnPosition = false;
        GFX.localScale /= 1.1f;
    }

}
