using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AltigenOlustur : MonoBehaviour
{
    public InputField input1,input2;
    public int ans1,ans2;
    public GameObject  altıgenprizma;
    public GameObject feedback,feedbackolumlu,feedbackolumsuz;
    public void kontrolet(){
   int.TryParse(input1.text, out int Result);
   ans1= Result;
   
 int.TryParse(input2.text, out int Result1);
   ans2= Result1;
    
    if((ans1==6)&& (ans2==17) ){
   altıgenprizma.SetActive(true);
    }
    else
    feedback.SetActive(true);
   feedbackolumsuz.SetActive(true);
    }
}
