using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class puzzle : MonoBehaviour, IEndDragHandler, IDragHandler
{
    public GameObject shape1, shape2, shape3, shape4, shape5, shape6;
    public GameObject piece1,piece2,piece3,piece4,piece5,piece6;
    public GameObject piece1_1,piece5_1;
    public int i=11,j=11,k=11,p=11,r=11,s=11;
    public GameObject popup,devambutonu,devambutonuaktif;
   
    private RectTransform rectTransform;
    public Vector3 piece1Pos;
    
    public bool doluMuDik = false;
    public bool doluMuD1 = false;
    public bool doluMuD2 = false;
    public bool doluMuD3 = false;
    public bool doluMuD4 = false;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        piece1Pos = rectTransform.position;
       
    }
   

    public void OnDrag(PointerEventData eventData)
    {
       // Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta;
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if(doluMuD1 || doluMuD2 || doluMuD3 || doluMuD4){
        //rectTransform.position = piece1Pos;
        
        Debug.Log("OnEndDrag" + rectTransform.name);
            
        }
        else{
            rectTransform.position =piece1Pos;
        }

        Debug.Log(eventData.pointerDrag.gameObject.tag + "bıraktı");

        //  if(other.gameObject.tag == "d2"){
        //         doluMuD2=true;
        //           Debug.Log("çakıştı d2");
        //     }
               
        //     if(other.gameObject.tag == "d3"){

        //         doluMuD3=true;
        //          Debug.Log("çakıştı d3");
        //         }
        //     if(other.gameObject.tag == "d4"){
        //         doluMuD4=true;
        //         Debug.Log("çakıştı d4");
        //         }
        //     if(other.gameObject.tag == "dikdortgenPuzzle"){
        //         doluMuD1=true;
        //         Debug.Log("çakıştı d1");
        //         }
    }
     void Start(){
         doluMuDik=false;
         doluMuD1 =false;
         doluMuD2  =false; doluMuD3  =false; doluMuD4 =false;
     }
void Update(){
     if(doluMuD1 && doluMuD2 && doluMuD3 && doluMuD4 )
                doluMuDik = true;
    if(doluMuDik==true){
        Debug.Log("dikötrgenler tamam");

        }
}
    void OnTriggerEnter2D(Collider2D other)
    {
       Debug.Log("test"+ this.gameObject.tag);
        Debug.Log("test2"+  other.gameObject.tag);
      
        // if (other.gameObject.tag == "dikdortgenPuzzle")
        // {
        //     doluMu = false;
        //     rectTransform.position = other.transform.position;
            
            
        //       i=1;
        //       doluMu= false;

           
            
            
        // }
       
        //  if (other.tag == "d2")
        // {
        //     doluMu = false;
        //     rectTransform.position = other.transform.position;
            
        //     j=1;
        //     doluMu=false;
        // }   
        if (other.gameObject.tag == "d2" || other.gameObject.tag == "d3"  || other.gameObject.tag == "d4" || other.gameObject.tag == "dikdortgenPuzzle" )
        {
            if(other.gameObject.tag == "d2"){
                doluMuD2=true;
                //this.gameObject bu tuutuğun dikdörtgen other olan da açık halindeki dikdörtgen
                other.gameObject.SetActive(false);
                this.gameObject.SetActive(false);
                piece5_1.SetActive(true);
                  Debug.Log("çakıştı d2");
            }
               
            if(other.gameObject.tag == "d3"){

                doluMuD3=true;
                 Debug.Log("çakıştı d3");
                }
            if(other.gameObject.tag == "d4"){
                doluMuD4=true;
                Debug.Log("çakıştı d4");
                }
            if(other.gameObject.tag == "dikdortgenPuzzle"){
                doluMuD1=true;
                  other.gameObject.SetActive(false);
                this.gameObject.SetActive(false);
                piece1_1.SetActive(true);
                Debug.Log("çakıştı d1");
                }
            if(doluMuD1 && doluMuD2 && doluMuD3 && doluMuD4)
                doluMuDik = true;
            this.transform.position = other.transform.position;
            Debug.Log("çakıştı");
           // other.tag = "d3var";
            k=1;
        }
        else{
            doluMuDik=false;
            doluMuD1=false;
            doluMuD2=false;
            doluMuD3=false;
            doluMuD4=false;
        }
       
        // if (other.tag == "d4")
        // {
        //     doluMu = false;
        //     rectTransform.position = other.transform.position;
        //     other.tag = "d4var";
        //     p=1;
        // }  
        // if (other.tag == "karePuzzle")
        // {
        //     doluMu = false;
        //     rectTransform.position = other.transform.position;
        //     other.tag = "kareBos";
        //     r=1;
        // }
        // if (other.tag == "k1")
        // {
        //     doluMu = false;
        //     rectTransform.position = other.transform.position;
        //     other.tag = "k1var";
        //     s=1;
        // }
        // if ((i == 1)&&(j==1)&&(k==1)&&(p==1)&&(r==1)&&(s==1))
        // {
        //   devambutonu.SetActive(false);
        //   devambutonuaktif.SetActive(true);
        // } 
        //  if (shape1.tag == piece1.tag){
            
        //     i=1;
        // }
         

        // if (shape2.tag == piece2.tag){
            

        //     j=1;
        // }

        // if (shape3.tag == piece3.tag){
            

        //     k=1;
        // }
        // if (shape4.tag == piece4.tag)
        //    {    
        //         p=1;
        //    }
        // if (shape5.tag == piece5.tag)
        //   {  
        //        r=1;}

        // if (shape6.tag == piece6.tag)
        //    {
               
        //        s=1;
        //    }
        //    if ((i == 1)&&(j==1)&&(k==1)&&(p==1)&&(r==1)&&(s==1))
        // {
        //   devambutonu.SetActive(false);
        //   devambutonuaktif.SetActive(true);
        // } 
    }
     
           
    

     
   
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "d2" || other.gameObject.tag == "d3"  || other.gameObject.tag == "d4" || other.gameObject.tag == "dikdortgenPuzzle" )
        {
            if(other.gameObject.tag == "d2")
                doluMuD2=false;
            if(other.gameObject.tag == "d3")
                doluMuD3=false;
            if(other.gameObject.tag == "d4")
                doluMuD4=false;
            if(other.gameObject.tag == "dikdortgenPuzzle")
                doluMuD1=false;
            if(doluMuD1 && doluMuD2 && doluMuD3 && doluMuD4)
                doluMuDik = true;
            //his.transform.position = other.transform.position;
            Debug.Log("çıktı"+ other.gameObject.tag );
            
           
           // other.tag = "d3var";
       
        }
        
        // if (other.tag == "dikdortgenPuzzle" || other.tag == "dikdortgenBos")
        // {
        //     doluMu = true;
        //     other.tag = "dikdortgenPuzzle";
        // }
        //  if (other.tag == "karePuzzle" || other.tag == "kareBos")
        // {
        // doluMu = true;
        // other.tag = "karePuzzle";
        // }
    }
}
