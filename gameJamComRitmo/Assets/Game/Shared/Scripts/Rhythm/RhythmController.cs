using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythmController : MonoBehaviour
{
    public float currentSongTime = 0;
    [Range(0.1f, 10f)]
    public float IdealTimeToBong = 1;
    public float VariationTimeToBong = 0.1f;
    public float lastBongTime = 0;

    [Space]
    public int perfectTime = 0;
    public int AllTime = 0;

    void Update()
    {
        currentSongTime += Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            float bong = (currentSongTime - lastBongTime);
            if (bong >= (IdealTimeToBong - VariationTimeToBong) && bong <= ((IdealTimeToBong + VariationTimeToBong)))
            {
                perfectTime++;
            }
            AllTime++;
            lastBongTime = currentSongTime;
        }
    }
}
