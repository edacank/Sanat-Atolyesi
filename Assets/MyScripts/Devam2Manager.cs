using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devam2Manager : MonoBehaviour
{       public GameObject DevamButonu,DevamButonu_aktif;
         public GameObject feedback,feedbackpositive,feedbacknegative;
         public GameObject text1_dikdörtgen,text1_ucgen,text1altıgen,text1besgen,text1silindir,text1koni,konusma;
         public GameObject makine_dikdörtgen,makine2_besgen,makine2_altıgen,makine2_ucgen,makine2_silindir,makine2_koni, frameoykusonu,framemakine;
    // Start is called before the first frame update
    public int i =0;
    
public void click(){
i++;
Debug.Log("click");
devam();


}

   public void devam(){

     switch(i){

    case 1:
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    makine_dikdörtgen.SetActive(false);
    text1_dikdörtgen.SetActive(false);
    text1_ucgen.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    makine2_ucgen.SetActive(true);
    break;
    case 2:
     DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    makine2_ucgen.SetActive(false);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    makine2_besgen.SetActive(true);
    text1_ucgen.SetActive(false);
    text1besgen.SetActive(true);
    break;
    case 3:
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    makine2_besgen.SetActive(false);
    makine2_altıgen.SetActive(true);
    text1besgen.SetActive(false);
    text1altıgen.SetActive(true);
    break;
    case 4:
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    makine2_altıgen.SetActive(false);
    makine2_silindir.SetActive(true);
    text1altıgen.SetActive(false);
    text1silindir.SetActive(true);
    break;
    case 5:
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    makine2_silindir.SetActive(false);
    makine2_koni.SetActive(true);
    text1silindir.SetActive(false);
    text1koni.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    makine2_silindir.SetActive(false);
    break;
  
   
    case 6:
    framemakine.SetActive(false);
    frameoykusonu.SetActive(true);
    break;
     }
}}
