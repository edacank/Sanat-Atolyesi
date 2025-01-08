using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class puzzle3 : MonoBehaviour, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    public Vector3 piece1Pos;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        piece1Pos = rectTransform.position;
    }
    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
            rectTransform.position = piece1Pos;
    }
}
