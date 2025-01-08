using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SilindirOlustur : MonoBehaviour
{

    public InputField input1,input2;
    public int ans1,ans2;
    public GameObject  silindir;
    public GameObject feedback,feedbackolumlu,feedbackolumsuz;
    public void kontrolet(){
   int.TryParse(input1.text, out int Result);
   ans1= Result;
   
 int.TryParse(input2.text, out int Result1);
   ans2= Result1;
    
    if((ans1==10)&& (ans2==8) ){
   silindir.SetActive(true);
    }
    else
    feedback.SetActive(true);
   feedbackolumsuz.SetActive(true);
    }
}
