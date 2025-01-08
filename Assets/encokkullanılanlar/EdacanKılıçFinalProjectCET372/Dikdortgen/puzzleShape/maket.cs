using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class maket : MonoBehaviour
{
    public GameObject shape1, shape2, shape3, shape4, shape5, shape6;
    
    public int i=11,j=11,k=11,p=11,r=11,s=11;
    public GameObject popup,devambutonu,devambutonuaktif;
    
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
        if(doluMu)
        rectTransform.position = piece1Pos;
        
        Debug.Log("OnEndDrag" + rectTransform.name);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "dikdortgenPuzzle")
        {
            doluMu = false;
            rectTransform.position = other.transform.position;
            other.tag = "dikdortgenBos";
        }
            
    }

       
   
    void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "dikdortgenPuzzle" || other.tag == "dikdortgenBos")
        {
            doluMu = true;
            other.tag = "dikdortgenPuzzle";
        }
    }
}
