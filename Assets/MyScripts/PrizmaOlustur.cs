using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrizmaOlustur : MonoBehaviour
{   public InputField input1,input2,input3,input4,input5;
    public int ans1,ans2,ans3,ans4,ans5;
    public GameObject dprizma;
    public GameObject feedback,feedbackolumlu,feedbackolumsuz;
    public void kontrolet(){
   int.TryParse(input1.text, out int Result);
   ans1= Result;
   
 int.TryParse(input2.text, out int Result1);
   ans2= Result1;
    int.TryParse(input3.text, out int Result2);
   ans3= Result2;
    if((ans1==5)&& (ans2==3) && (ans3==12)){
   dprizma.SetActive(true);
    }
    else
    feedback.SetActive(true);
   feedbackolumsuz.SetActive(true);
    }
}
