using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class puzzle2 : MonoBehaviour, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    public Vector3 piece1Pos;

    public bool doluMu = true;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        piece1Pos = rectTransform.position;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (doluMu)
            rectTransform.position = piece1Pos;

        Debug.Log("OnEndDrag" + rectTransform.name);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "karePuzzle")
        {
            doluMu = false;
            rectTransform.position = other.transform.position;
            other.tag = "kareBos";
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "karePuzzle" || other.tag == "kareBos")
        {
        doluMu = true;
        other.tag = "karePuzzle";
        }
    }
}
