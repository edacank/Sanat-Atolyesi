using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BesgenOlustur : MonoBehaviour
{
 public InputField input1,input2;
    public int ans1,ans2;
    public GameObject  besgenprizma;
    public GameObject feedback,feedbackolumlu,feedbackolumsuz;
    public void kontrolet(){
   int.TryParse(input1.text, out int Result);
   ans1= Result;
   
 int.TryParse(input2.text, out int Result1);
   ans2= Result1;
    
    if((ans1==5)&& (ans2==9) ){
   besgenprizma.SetActive(true);
    }
    else
    feedback.SetActive(true);
   feedbackolumsuz.SetActive(true);
    }




}
