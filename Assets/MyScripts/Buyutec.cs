using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Buyutec : MonoBehaviour, IEndDragHandler, IDragHandler
{
    // Start is called before the first frame update
     public GameObject isikliPrizma, buyutecliPrizma, infoButton;
    private RectTransform rectTransform;
    public Vector3 glassPos;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        glassPos = rectTransform.position;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       rectTransform.position = glassPos;
        Debug.Log("OnEndDrag");
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        buyutecliPrizma.SetActive(true);
        infoButton.SetActive(true);
        Debug.Log("OnTriggerEnter2D  " + other.name);
    }

    void OnTriggerExit2D(Collider2D other)
    { 
        buyutecliPrizma.SetActive(false);
    }
}
