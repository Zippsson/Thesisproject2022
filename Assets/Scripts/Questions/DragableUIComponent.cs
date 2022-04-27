using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragableUIComponent : EventTrigger
{
    private Collider2D col;

    public bool startDragging;
    private Vector2 startPos;
    private void Awake()
    {
        col = GetComponent<Collider2D>();
        startPos = transform.position;
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
        //col.enabled = false;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        startDragging = false;
        //col.enabled = true;
    }

    public void ResetPos()
    {
        transform.position = startPos;
        gameObject.GetComponent<Rigidbody2D>().position = startPos;
    }
}
