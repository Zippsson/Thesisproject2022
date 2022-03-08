using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragableUIComponent : EventTrigger
{
    private Collider2D col;
    private bool startDragging;
    private void Start()
    {
        col = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (startDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        startDragging = true;
        col.enabled = false;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        startDragging = false;
        col.enabled = true;
    }
}
