using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RhythmController : MonoBehaviour
{
    public float currentSongTime = 0;
    [Range(0.1f, 10f)]
    public float IdealTimeToBong = 1;
    public float VariationTimeToBong = 0.1f;
    public float lastBongTime = 0;

    [Space]
    public int correctHits = 0;
    public int allHits = 0;

    [Space]
    public Slider Slider;

    void Update()
    {
        currentSongTime += Time.deltaTime;
        float bong = (currentSongTime - lastBongTime);

        Slider.value = bong / IdealTimeToBong;

        if()

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (bong >= (IdealTimeToBong - VariationTimeToBong) && bong <= ((IdealTimeToBong + VariationTimeToBong)))
        //    {
        //        correctHits++;
        //    }
        //    allHits++;
        //    lastBongTime = currentSongTime;
        //}
    }
}
