using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RhythmController : MonoBehaviour
{
    [Header("Status")]
    public int correctHits = 0;
    public int allHits = 0;
    [Header("Flags")]
    public bool NeedleOnPosition = false;
    public bool canSpawnNotes;
    [Header("Notes settings")]
    public GameObject note;
    public RectTransform noteSpawner;
    public float noteSpawnTime;
    public float noteSpeed;
    [Space]
    public RectTransform UI_Parent;
    public RhythmNeedle needle;
    [HideInInspector]
    public GameObject currentNote = null;

    private Vector3 needleScale;

    public static event EventHandler onCorrectHit;

    private void Start()
    {
        needleScale = needle.GFX.localScale;

        StartCoroutine(StartSpawningNotes());
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if(NeedleOnPosition)
            {
                correctHits++;
                onCorrectHit?.Invoke(this, null);
                NeedleOnPosition = false;
            }
            allHits++;
            Destroy(currentNote);
            needle.GFX.localScale = needleScale;
        }
    }
    
    IEnumerator StartSpawningNotes()
    {
        WaitForSeconds s = new WaitForSeconds(noteSpawnTime);

        while(canSpawnNotes)
        {
            SpawnNote();
            yield return s;
        }
    }

    private void SpawnNote()
    {
        GameObject noteGO = Instantiate(note, noteSpawner.anchoredPosition, Quaternion.identity);
        RhythymNoteController noteController = noteGO.GetComponent<RhythymNoteController>();
        noteController.speed = noteSpeed;
        noteGO.transform.SetParent(UI_Parent, false);

    }




}
