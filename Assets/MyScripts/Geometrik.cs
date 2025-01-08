//using UnityEngine.EventSystems;  // For PointerEventData, IEndDragHandler, IDragHandler
using UnityEngine.UI;            // For InputField

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Geometrik : MonoBehaviour, IEndDragHandler, IDragHandler
{    
     private RectTransform rectTransform;
     public Vector3 geoPos;
     public GameObject DevamButonu,DevamButonu_aktif;
     public GameObject dk1,dk2,dk3,dk4,dk5,dk6,dk7,dk8,dk9,dk10,dk11,dk12,dk13,dk14,dk15,dk16;
     public GameObject kr1,kr2,kr3,kr4,kr5;
     public GameObject uc1,uc2;
     public GameObject b1,b2;
     public GameObject a1,a2,da1,da2,da3,dd1;
     public int i=0, j=0,k=0,m=0,n=0,p=0,r=0;
    
    
     private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        geoPos = rectTransform.position;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        rectTransform.position = geoPos;
        Debug.Log("OnEndDrag");
    }
    void OnTriggerEnter2D(Collider2D other)
    { //dikdörtgenler
       if(other.tag == "dk1")
        {
            dk1.SetActive(true);
            other.tag = "dk1var";
           i=1;
            
        }
       if(other.tag == "dk2")
        {
            dk2.SetActive(true);
            other.tag = "dk2var";
           j=1;
            
        }
         if(other.tag == "dk3")
        {
            dk3.SetActive(true);
            other.tag = "dk3var";
           m=1;
            
        }
         if(other.tag == "dk4")
        {
            dk4.SetActive(true);
            other.tag = "dk4var";
           n=1;
            
        }
        if(other.tag == "dk5")
        {
            dk5.SetActive(true);
            other.tag = "dk5var";
           p=1;
            
        }
        if(other.tag == "dk6")
        {
            dk6.SetActive(true);
            other.tag = "dk6var";
           r=1;
            
        }
        if((i==1)&&(j==1)&&(m==1)&&(n==1)&&(p==1)&&(r==1)){

            DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);



        }
        if(other.tag == "dk7")
        {
            dk7.SetActive(true);
            other.tag = "dk7var";
           
            
        }
        if(other.tag == "dk8")
        {
            dk8.SetActive(true);
            other.tag = "dk8var";
           
            
        }
        if(other.tag == "dk9")
        {
            dk9.SetActive(true);
            other.tag = "dk9var";
           
            
        }
        if(other.tag == "dk10")
        {
            dk10.SetActive(true);
            other.tag = "dk10var";
           
            
        }
          if(other.tag == "dk11")
        {
            dk11.SetActive(true);
            other.tag = "dk11var";
           
            
        }
         if(other.tag == "dk12")
        {
            dk12.SetActive(true);
            other.tag = "dk12var";
           
            
        }
          if(other.tag == "dk13")
        {
            dk13.SetActive(true);
            other.tag = "dk13var";
           
            
        }
          if(other.tag == "dk14")
        {
            dk14.SetActive(true);
            other.tag = "dk14var";
           
            
        }
          if(other.tag == "dk15")
        {
            dk15.SetActive(true);
            other.tag = "dk15var";
            
        }
         if(other.tag == "dk16")
        {
            dk16.SetActive(true);
            other.tag = "dk16var";
            
        }
        //kareler
         if(other.tag == "kr1")
        {
            kr1.SetActive(true);
            other.tag = "kr1var";
           
            
        }
         if(other.tag == "kr2")
        {
            kr2.SetActive(true);
            other.tag = "kr2var";
           
            
        }
        if(other.tag == "kr3")
        {
            kr3.SetActive(true);
            other.tag = "kr3var";
           
            
        }
        if(other.tag == "kr4")
        {
            kr4.SetActive(true);
            other.tag = "kr4var";
           
            
        }
        if(other.tag == "kr5")
        {
            kr5.SetActive(true);
            other.tag = "kr5var";
           
            
        }
        //ucgenler
        if(other.tag == "uc1")
        {
            uc1.SetActive(true);
            other.tag = "uc1var";
           
            
        }
          if(other.tag == "uc2")
        {
            uc2.SetActive(true);
            other.tag = "uc2var";
           
            
        }
        //besgenler
        if(other.tag == "b1")
        {
            b1.SetActive(true);
            other.tag = "b1var";
           
            
        }if(other.tag == "b2")
        {
           b2.SetActive(true);
            other.tag = "b2var";
           
            
        }
        //altıgenler 
          if(other.tag == "a1")
        {
            a1.SetActive(true);
            other.tag = "a1var";
           
            
        }
         if(other.tag == "a2")
        {
            a2.SetActive(true);
            other.tag = "a2var";
           
            
        }
        //daireler
         if(other.tag == "da1")
        {
            da1.SetActive(true);
            other.tag = "da1var";
            
        }
        if(other.tag == "da2")
        {
            da2.SetActive(true);
            other.tag = "da2var";
            
        }
          if(other.tag == "da3")
        {
            da3.SetActive(true);
            other.tag = "da3var";
            
        }
        //dairedilimi
          if(other.tag == "dd1")
        {
            dd1.SetActive(true);
            other.tag = "dd1var";
            
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        //   isikliPrizma.SetActive(true);
       // buyutecliPrizma.SetActive(false);
        Debug.Log("OnTriggerExit2D  " + other.name);
    }

}
