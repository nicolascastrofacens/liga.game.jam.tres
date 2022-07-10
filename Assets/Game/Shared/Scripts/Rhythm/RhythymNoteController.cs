using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythymNoteController : MonoBehaviour
{
    public float speed = 5;

    public RhythymNoteController previousNote = null;

    private RectTransform _transform;

    private void Start()
    {
        _transform = GetComponent<RectTransform>();
    }

    void Update()
    {
        _transform.Translate(Vector3.left * speed * Time.deltaTime, Space.Self);
    }

    public void DestroyNote()
    {
        Destroy(gameObject);
    }
}
