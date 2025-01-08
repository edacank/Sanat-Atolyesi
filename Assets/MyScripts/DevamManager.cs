using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevamManager : MonoBehaviour
{
    // Start is called before the first frame update
         public GameObject DevamButonu,DevamButonu_aktif,devamucuncu;
         public GameObject feedback,feedbackpositive,feedbacknegative;
          public GameObject ısıklıprizma,ucgenprizma,altıgenprizma,besgenprizma,acıkhali,acikhali_ucgenprizma,acikhali_besgenprizma,acıkhali_altıgenprizma;
         public GameObject yonerge1,yonerge2,yonerge3,yonerge4,yonerge5;
         public GameObject yonerge6,yonerge7,yonerge8,yonerge9,yonerge10,yonerge11,yonerge12;
         public GameObject yonerge13,yonerge14,yonerge15,yonerge16,yonerge17,yonerge18;
         public GameObject frameprintergiris,frameyapboz;
         public GameObject acıkhali_silindir,silindir;
         public GameObject acıkhali_koni, koni;
         public GameObject geometriksekiller;
         int i =0;
    public void giris(){

DevamButonu.SetActive(true);
DevamButonu_aktif.SetActive(false);
}
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
    acıkhali.SetActive(true);
    geometriksekiller.SetActive(true);
    ısıklıprizma.SetActive(false);
    yonerge1.SetActive(false);
    yonerge2.SetActive(true);
    break;

    case 2:
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    geometriksekiller.SetActive(false);
       yonerge2.SetActive(false);
       yonerge3.SetActive(true);    
    
    Debug.Log("case2");

    break;
    case 3:
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    acıkhali.SetActive(false);
    ısıklıprizma.SetActive(true);
    break;

    case 4:
    ısıklıprizma.SetActive(false);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    yonerge3.SetActive(false);
    yonerge4.SetActive(true);
    ucgenprizma.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    Debug.Log("case4");
    break;
    case 5:
  
    ucgenprizma.SetActive(false);
    acikhali_ucgenprizma.SetActive(true);
    geometriksekiller.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    yonerge4.SetActive(false);
    yonerge5.SetActive(true);
    Debug.Log("case5");
    break;
    
    case 6:
    yonerge5.SetActive(false);
    yonerge6.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    geometriksekiller.SetActive(false);
   
    Debug.Log("case4");
    break;
    case 7: 
    acikhali_ucgenprizma.SetActive(false);
    ucgenprizma.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
   break;
    case 8:
    yonerge6.SetActive(false);
    yonerge7.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    besgenprizma.SetActive(true);
    ucgenprizma.SetActive(false);

     break;
      case 9:
       yonerge7.SetActive(false);
       yonerge8.SetActive(true);
       feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    acikhali_besgenprizma.SetActive(true);
    geometriksekiller.SetActive(true);
    besgenprizma.SetActive(false);
    break;
       case 10:
       yonerge8.SetActive(false);
       yonerge9.SetActive(true);
       feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    geometriksekiller.SetActive(false);
    break;
    case 11:
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    besgenprizma.SetActive(true);
    acikhali_besgenprizma.SetActive(false);
    break;

    case 12:
    besgenprizma.SetActive(false);
    yonerge9.SetActive(false);
    yonerge10.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    altıgenprizma.SetActive(true);
    break;
    case 13:
    altıgenprizma.SetActive(false);
    yonerge10.SetActive(false);
    yonerge11.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    acıkhali_altıgenprizma.SetActive(true);
    geometriksekiller.SetActive(true);
    break;
    case 14:
    yonerge11.SetActive(false);
    yonerge12.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    geometriksekiller.SetActive(false);
    break;
    case 15:
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
   geometriksekiller.SetActive(false);
    altıgenprizma.SetActive(true);
    acıkhali_altıgenprizma.SetActive(false);
    break;
    case 16: 
    altıgenprizma.SetActive(false);
    silindir.SetActive(true);
    yonerge12.SetActive(false);
    yonerge13.SetActive(true);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    break;
    case 17:
    silindir.SetActive(false);
    acıkhali_silindir.SetActive(true);
    geometriksekiller.SetActive(true);
    yonerge13.SetActive(false);
    yonerge14.SetActive(true);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    break;
    case 18:
    geometriksekiller.SetActive(false);
    yonerge14.SetActive(false);
    yonerge15.SetActive(true);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    break;
    case 19:
    acıkhali_silindir.SetActive(false);
    silindir.SetActive(true);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    break;
    case 20:
    silindir.SetActive(false);
    koni.SetActive(true);
    yonerge15.SetActive(false);
    yonerge16.SetActive(true);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    break;
    case 21:
    koni.SetActive(false);
    acıkhali_koni.SetActive(true);
    geometriksekiller.SetActive(true);
    yonerge16.SetActive(false);
    yonerge17.SetActive(true);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    break;
    case 22:
    geometriksekiller.SetActive(false);
    yonerge17.SetActive(false);
    yonerge18.SetActive(true);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    break;
    case 23:
    koni.SetActive(true);
    acıkhali_koni.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    DevamButonu.SetActive(false);
    break;
    case 24:
    koni.SetActive(false);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    DevamButonu_aktif.SetActive(false);
    DevamButonu.SetActive(false);
    devamucuncu.SetActive(true);
    break;
  
    }
}}