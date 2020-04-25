using UnityEngine;
using System.Collections;
using System;
 
public class CameraMove : MonoBehaviour
{

    void Update()
    {
        if (_State == State.None && Input.GetMouseButtonDown(0)) InitDrag();

        if (_State == State.Dragging && Input.GetMouseButton(0)) MoveCamera();

        if (_State == State.Dragging && Input.GetMouseButtonUp(0)) FinishDrag();
    }

    #region Calculations
    public State _State = State.None;
    public Vector3 _DragStartPos;

    private void InitDrag()
    {
        _DragStartPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0f, -10f));

        _State = State.Dragging;
    }

    private void MoveCamera()
    {
        Vector3 actualPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0f, -10f));
        Vector3 dragDelta = actualPos - _DragStartPos;


        if (Math.Abs(dragDelta.x) < 0.00001f && Math.Abs(dragDelta.y) < 0.00001f) return;

        Camera.main.transform.Translate(-dragDelta.x, 0f, 0f);

    }

    private void FinishDrag()
    {
        _State = State.None;
    }
    #endregion

    public enum State
    {
        None,
        Dragging
    }
}