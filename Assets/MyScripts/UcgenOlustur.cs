using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UcgenOlustur : MonoBehaviour
{
  public InputField input1,input2,input3,input4,input5;
    public int ans1,ans2,ans3,ans4,ans5;
    public GameObject ucgenprizma;
    public GameObject feedback,feedbackolumlu,feedbackolumsuz;
    public void kontrolet(){
   int.TryParse(input1.text, out int Result);
   ans1= Result;
   
 int.TryParse(input2.text, out int Result1);
   ans2= Result1;
    if((ans1==7)&& (ans2==15)){
   ucgenprizma.SetActive(true);
    }
    else
    feedback.SetActive(true);
   feedbackolumsuz.SetActive(true);
    }
}
