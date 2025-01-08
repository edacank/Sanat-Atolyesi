using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{      int i=0;
    public GameObject yonerge1,devamikinci;
    public GameObject yonerge2,yonerge2soru;
    public GameObject yonerge3,yonerge4,yonerge4soru,yonerge5,yonerge6,yonerge6soru,yonerge7,yonerge8,yonerge9,yonerge10,yonerge10soru;
    public GameObject yonerge11,yonerge12,yonerge12soru,yonerge13,yoneger131,yonerge14,yonerge14soru,yonerge15,yonerge16,yonerge16soru,yonerge17;
      public GameObject yonerge18,yonerge19,yonerge20,yonerge21,yonerge21soru,yonerge22,yonerge23,yonerge23soru,yonerge24;
      public GameObject yonerge25,yonerge25soru,yonerge26,yonerge27,yonerge27soru,yonerge28,yonerge29,yonerge30;
      public GameObject yonerge31,yonerge32, yonerge32soru,yonerge33,yonerge34,yonerge34soru,yonerge35,yonerge36,yonerge36soru,yonerge37;
      public GameObject yonerge38,yonerge38soru,yonerge39,yonerge40,yonerge41,yonerge42,yonerge42soru,yonerge43;
      
    public GameObject DevamButonu, DevamButonu_aktif;
    public GameObject isikliPrizma,isikliprizmasol,kurdelaprizma,kurdelaprizmasol,koseliprizma,koseliprizmadevrik;
    public GameObject dprizmaalttaban,dprizmausttaban,dprizmayanal1,dprizmayanal2;
    public GameObject ucgenprizmatabanayritlari,ucgenprizmatabanayrıtı2,ucgenkurdeleprizma,ucgenkurdele2;
    public GameObject koseliucgenprizma,uckoseliucgenprizma,ucgenprizmaalttaban,ucgenprizmausttaban;
    public GameObject ucgenprizmayanal1,ucgenprizmayanal2,ucgenprizmayanal3;
    public GameObject feedback,feedbackpositive,feedbacknegative,frame3,frame4,printer_giris,frameprinter;
    public GameObject besgenısıklıprizma,besgenısıklıprizmasol,besgenkurdelaprizma,besgenkurdelaprizmasol,besgenkoseli,besgenkoselisol,besgenusttaban,besgenalttaban,besgenyanalalanlar;
    public GameObject besgen1yanalalanlar2,besgen2yanalalanlar2,altıgenısıklıprizma,altıgenprizmasol;
    public GameObject altıgenkurdelaprizma,altıgenkurdelaprizmasol,altıgenkoseli,altıgenkoselisol,altıgenusttaban,altıgenalttaban;
    public GameObject altıgenyanalalanlar,altıgen2yanalalanlar2;
     public GameObject acıkhali,pieces,acikhali_ucgenprizma,pieces_ucgenprizma,acikhali_besgenprizma,pieces_besgenprizma,acıkhali_altıgenprizma,pieces_altıgenprizma;
     public GameObject frame5;
     //not defteri kısmı
     public GameObject notdefterininarkaplanı_dikdortgen,notarkaucgen,notarkabesgen,notarkaaltıgen,notdefterininarkası_ngen,dtablo,utablo,btablo,atablo;
     //alet çantası
     public GameObject cantaici;
     //buyutec
     public GameObject buyutecdyanal,buyutecdtaban,buyutecdkose;
     public GameObject infobutonuyanal,infobutonutaban,infobutonukose;
public InputField input1,input2,input3,input4,input5,input6,input7,input8,input9,input10,input11,input12,input13,input14,input15;
public InputField input16,input17,input18,input19,input20,input21,input22,input23,input24,input25;

    public int ans1,ans2,ans3,ans4,ans5,ans6,ans7,ans8,ans9,ans10,ans11,ans12,ans13,ans14,ans15;
    public int ans16,ans17,ans18,ans19,ans20,ans21,ans22,ans23,ans24,ans25;
    public GameObject  dimg1,dimg2,dimg3,dimg4,uimg1,uimg2,uimg3,uimg4,bimg1,bimg2,bimg3,bimg4,aimg1,aimg2,aimg3,aimg4;
    public GameObject kaydet1,kaydet2,kaydet3,kaydet4,kaydet5,kaydet6,kaydet7,kaydet8,kaydet9,kaydet10,kaydet11,kaydet12;
    public GameObject kaydet13,kaydet14,kaydet15,kaydet16,kaydet17;
    public GameObject notdefteri,notdefteri_ucgen,notdefteri_besgen,notdefteri_altıgen,notdefteri_ngen;
  
    public void kontrolet1(){
   int.TryParse(input1.text, out int Result1);
   ans1= Result1;
    if(ans1==8){
   dimg2.SetActive(true);
   feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notdefterininarkaplanı_dikdortgen.SetActive(false);
   kaydet1.SetActive(false);
   kaydet2.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
    }
    
    public void kontrolet2(){

   int.TryParse(input2.text, out int Result2);
   ans2= Result2;
   int.TryParse(input3.text, out int Result3);
   ans3= Result3;
    if((ans2==4)&&(ans3==12)){
    dimg3.SetActive(true);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notdefterininarkaplanı_dikdortgen.SetActive(false);
  kaydet2.SetActive(false);
  kaydet3.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
     }
    public void kontrolet3(){

   int.TryParse(input4.text, out int Result4);
   ans4= Result4;
    if(ans4==8){
    dimg4.SetActive(true);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notdefterininarkaplanı_dikdortgen.SetActive(false);
  kaydet3.SetActive(false);
  kaydet4.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
    }
    public void kontrolet4(){

   int.TryParse(input5.text, out int Result5);
   ans5= Result5;
    if(ans5==6){
    kaydet3.SetActive(false);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notdefterininarkaplanı_dikdortgen.SetActive(false);
   
   notdefteri.SetActive(false);
   notdefteri_ucgen.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }}

     public void kontrolet5(){

   int.TryParse(input6.text, out int Result6);
   ans6= Result6;
    if(ans6==6){
      uimg2.SetActive(true);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notarkaucgen.SetActive(false);
   kaydet5.SetActive(false);
   kaydet6.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
     }
    public void kontrolet6(){

   int.TryParse(input7.text, out int Result7);
   ans7= Result7;
   int.TryParse(input8.text, out int Result8);
   ans8= Result8;
    if((ans7==3)&&(ans8==9)){
    uimg3.SetActive(true);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notarkaucgen.SetActive(false);
  kaydet6.SetActive(false);
  kaydet7.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
    }
    public void kontrolet7(){

   int.TryParse(input9.text, out int Result9);
   ans9= Result9;
    if(ans9==6){
    uimg4.SetActive(true);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notarkaucgen.SetActive(false);
  kaydet6.SetActive(false);
  kaydet7.SetActive(false);
  kaydet8.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
    }
    public void kontrolet8(){

   int.TryParse(input10.text, out int Result10);
   ans10= Result10;
    if(ans10==5){
    kaydet7.SetActive(false);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notarkaucgen.SetActive(false);
   notdefteri_ucgen.SetActive(false);
   notdefteri_besgen.SetActive(true);
   kaydet8.SetActive(false);
   kaydet9.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
    }
    public void kontrolet9(){

   int.TryParse(input11.text, out int Result11);
   ans11= Result11;
    if(ans11==10){
      bimg2.SetActive(true);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notarkabesgen.SetActive(false);
   kaydet9.SetActive(false);
   kaydet10.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
     }
    public void kontrolet10(){

   int.TryParse(input12.text, out int Result12);
   ans12= Result12;
   int.TryParse(input13.text, out int Result13);
   ans13= Result13;
    if((ans12==5)&&(ans13==15)){
    bimg3.SetActive(true);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notarkabesgen.SetActive(false);
  kaydet10.SetActive(false);
  kaydet11.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
    }
    public void kontrolet11(){

   int.TryParse(input14.text, out int Result14);
   ans14= Result14;
    if(ans14==10){
    bimg4.SetActive(true);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notarkabesgen.SetActive(false);
  kaydet11.SetActive(false);
  kaydet12.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
    }
    public void kontrolet12(){

   int.TryParse(input15.text, out int Result15);
   ans15= Result15;
    if(ans15==7){
    kaydet12.SetActive(false);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notarkaucgen.SetActive(false);
   notarkabesgen.SetActive(true);
   notdefteri.SetActive(false);
   notdefteri_besgen.SetActive(false);
   notdefteri_altıgen.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
    }
  public void kontrolet13(){

   int.TryParse(input16.text, out int Result16);
   ans16= Result16;
    if(ans16==12){
      aimg2.SetActive(true);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notarkaaltıgen.SetActive(false);
  
   kaydet13.SetActive(false);
   kaydet14.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
     }
    public void kontrolet14(){

   int.TryParse(input17.text, out int Result17);
   ans17= Result17;
   int.TryParse(input18.text, out int Result18);
   ans18= Result18;
    if((ans17==6)&&(ans18==18)){
    aimg3.SetActive(true);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notarkaaltıgen.SetActive(false);
  kaydet14.SetActive(false);
  kaydet15.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
    }
    public void kontrolet15(){

   int.TryParse(input19.text, out int Result19);
   ans19= Result19;
    if(ans19==12){
    aimg4.SetActive(true);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notarkaaltıgen.SetActive(false);
  kaydet15.SetActive(false);
  kaydet16.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
    }
    public void kontrolet16(){

   int.TryParse(input20.text, out int Result20);
   ans20= Result20;
    if(ans20==8){
    kaydet15.SetActive(false);
    feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notarkaucgen.SetActive(false);
   notarkaaltıgen.SetActive(false);
   notdefteri.SetActive(false);
   notdefteri_altıgen.SetActive(false);
   notdefteri_ngen.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
    }
   
    public void kontrolet17(){
   int.TryParse(input21.text, out int Result21);
   ans21= Result21;
   int.TryParse(input22.text, out int Result22);
   ans22= Result22;
    int.TryParse(input23.text, out int Result23);
   ans23= Result23;
   int.TryParse(input24.text, out int Result24);
   ans24= Result24;
      int.TryParse(input25.text, out int Result25);
   ans25= Result25;
    if((ans21==2)&&(ans22==1)&&(ans23==3)&&(ans24==2)&&(ans25==2)){
   
   feedback.SetActive(true);
  feedbackpositive.SetActive(true);
  feedbacknegative.SetActive(false);
   notdefterininarkası_ngen.SetActive(false);
   kaydet16.SetActive(false);
   kaydet17.SetActive(true);
    }
    else {
    feedback.SetActive(true);
    feedbacknegative.SetActive(true);
    }
    }
public void giris(){
yonerge1.SetActive(true);
DevamButonu.SetActive(true);
DevamButonu_aktif.SetActive(false);
devamikinci.SetActive(false);


}
public void click(){
i++;
Debug.Log("click");
devam();


}


    public void devam()
    {

     switch(i){

    case 1:
    DevamButonu.SetActive(true);
    DevamButonu_aktif.SetActive(false);
    isikliprizmasol.SetActive(true);
    isikliPrizma.SetActive(false);
    
    yonerge1.SetActive(false);
    yonerge2.SetActive(true);
    
  
    Debug.Log("case1");

    break;
    case 2:
    
    
     cantaici.SetActive(false);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge2.SetActive(false);
    yonerge2soru.SetActive(true);
  
    Debug.Log("case2");
    break;
    case 3:
    cantaici.SetActive(false);
    isikliprizmasol.SetActive(false);
    kurdelaprizma.SetActive(true);
    
    DevamButonu.SetActive(true);
    DevamButonu_aktif.SetActive(false);
    yonerge2soru.SetActive(false);
    yonerge3.SetActive(true);
    
     buyutecdtaban.SetActive(false);
      infobutonutaban.SetActive(false);
      buyutecdyanal.SetActive(true);
    
    Debug.Log("case3");
    
    
    break;
    case 4:
    
    kurdelaprizma.SetActive(false);
    
    kurdelaprizmasol.SetActive(true);
    
    DevamButonu.SetActive(true);
    DevamButonu_aktif.SetActive(false);

    
    yonerge3.SetActive(false);
    yonerge4.SetActive(true);
   
    Debug.Log("case4");
    break;
    case 5:
    kurdelaprizmasol.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge4.SetActive(false);
    yonerge4soru.SetActive(true);
    cantaici.SetActive(false);
   Debug.Log("case5");
    break;
    case 6:
    kurdelaprizmasol.SetActive(false);
    koseliprizma.SetActive(true);
    DevamButonu.SetActive(true);
    DevamButonu_aktif.SetActive(false);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge4soru.SetActive(false);
    yonerge5.SetActive(true);
     infobutonuyanal.SetActive(false);
    buyutecdyanal.SetActive(false);
    buyutecdkose.SetActive(true);
    Debug.Log("case6");
    break;
    case 7: 
    koseliprizma.SetActive(false);
    koseliprizmadevrik.SetActive(true);
     DevamButonu.SetActive(true);
    DevamButonu_aktif.SetActive(false);
    
    yonerge5.SetActive(false);
    yonerge6.SetActive(true);
      break;
    case 8: 
    
     DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    cantaici.SetActive(false);
   yonerge6.SetActive(false);
   yonerge6soru.SetActive(true);
    break;
    case 9: 
    koseliprizmadevrik.SetActive(false);
    dprizmausttaban.SetActive(true);
    DevamButonu.SetActive(true);
    DevamButonu_aktif.SetActive(false);
    yonerge6soru.SetActive(false);
    yonerge7.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    break;
    case 10:
    dprizmausttaban.SetActive(false);
    dprizmaalttaban.SetActive(true);
     DevamButonu.SetActive(true);
    DevamButonu_aktif.SetActive(false);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge7.SetActive(false);
    yonerge8.SetActive(true);
    break;
    case 11: 
    dprizmaalttaban.SetActive(false);
    dprizmayanal1.SetActive(true);
     DevamButonu.SetActive(true);
    DevamButonu_aktif.SetActive(false);
    yonerge8.SetActive(false);
    yonerge9.SetActive(true);
    break;
    case 12:
    dprizmayanal1.SetActive(false);
    dprizmayanal2.SetActive(true);
     DevamButonu.SetActive(true);
    DevamButonu_aktif.SetActive(false);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge9.SetActive(false);
    yonerge10.SetActive(true);
    break;
    case 13:
    yonerge10.SetActive(false);
    yonerge10soru.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    Debug.Log("yüzey damgalama not etme");
    break;
   
    case 14:
    yonerge10soru.SetActive(false);
    yonerge11.SetActive(true);
    dprizmayanal2.SetActive(false);
     DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    ucgenprizmatabanayritlari.SetActive(true);

    break;
    case 15:
    ucgenprizmatabanayritlari.SetActive(false);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    ucgenprizmatabanayrıtı2.SetActive(true);
    yonerge11.SetActive(false);
    yonerge12.SetActive(true);
    
    break;
    case 16:
    ucgenprizmatabanayrıtı2.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    
    yonerge12.SetActive(false);
    yonerge12soru.SetActive(true);
    Debug.Log("üçgen prizma bant not etme");
    break;
     
    case 17:
    ucgenkurdeleprizma.SetActive(true);
    ucgenprizmatabanayrıtı2.SetActive(false);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge12soru.SetActive(false);
    yonerge13.SetActive(true);
    break;
    case 18:
    ucgenkurdeleprizma.SetActive(false);
    ucgenkurdele2.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge13.SetActive(false);
    yonerge14.SetActive(true);
    
    break;
   
    case 19:
    
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge14.SetActive(false);
    yonerge14soru.SetActive(true);
    break; 
    case 20: 
    ucgenkurdele2.SetActive(false);
   koseliucgenprizma.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    
    yonerge14soru.SetActive(false);
    yonerge15.SetActive(true);

    break;
    
    case 21:
    koseliucgenprizma.SetActive(false);
    uckoseliucgenprizma.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
   yonerge15.SetActive(false);
   yonerge16.SetActive(true);
  
    
    break;
   
  case 22:
    
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge16.SetActive(false);
    yonerge16soru.SetActive(true);
    break; 
     case 23:
   uckoseliucgenprizma.SetActive(false);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    ucgenprizmausttaban.SetActive(true);
    yonerge17.SetActive(true);
    yonerge16soru.SetActive(false);
     
    break;
     case 24:
    ucgenprizmausttaban.SetActive(false);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    ucgenprizmaalttaban.SetActive(true);
    yonerge17.SetActive(false);
    yonerge18.SetActive(true);
    
    break;
    case 25:
    ucgenprizmayanal1.SetActive(true);
    ucgenprizmaalttaban.SetActive(false);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
       yonerge18.SetActive(false);
       yonerge19.SetActive(true);
    break;
    case 26:
    ucgenprizmayanal1.SetActive(false);
    ucgenprizmayanal2.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge19.SetActive(false);
    yonerge20.SetActive(true);
    
    break;
   case 27:
    ucgenprizmayanal2.SetActive(false);
    ucgenprizmayanal3.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge20.SetActive(false);
    yonerge21.SetActive(true);
   
    break;
     case 28:
    
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge21.SetActive(false);
    yonerge21soru.SetActive(true);
  
    break;
     case 29:
     ucgenprizmayanal3.SetActive(false);
    besgenısıklıprizma.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge21soru.SetActive(false);
    yonerge22.SetActive(true);
    break;
   case 30:
    besgenısıklıprizma.SetActive(false);
    besgenısıklıprizmasol.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge22.SetActive(false);
    yonerge23.SetActive(true);


    
    break;
     case 31:
      
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge23.SetActive(false);
    yonerge23soru.SetActive(true);
    
    break;
    case 32:
    besgenkurdelaprizma.SetActive(true);
    besgenısıklıprizmasol.SetActive(false);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge24.SetActive(true);
    yonerge23soru.SetActive(false);
    
    break;
   case 33:
    besgenkurdelaprizma.SetActive(false);
    besgenkurdelaprizmasol.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge25.SetActive(true);
    yonerge24.SetActive(false);
    
   

    break;
     case 34:
    
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge25.SetActive(false);
    yonerge25soru.SetActive(true);
    break;
    case 35:
    besgenkurdelaprizmasol.SetActive(false);
    besgenkoseli.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge25soru.SetActive(false);
    yonerge26.SetActive(true);
    
     
    break;
    case 36:
    besgenkoseli.SetActive(false);
    besgenkoselisol.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge27.SetActive(true);
    yonerge26.SetActive(false);
    break;
    case 37:
   
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge27soru.SetActive(true);
    yonerge27.SetActive(false);
    
    break;
      case 38:
     besgenkoselisol.SetActive(false);
     besgenusttaban.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge28.SetActive(true);
    yonerge27soru.SetActive(false);
    
    break;
    case 39:
    besgenusttaban.SetActive(false);
    besgenalttaban.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge28.SetActive(false);
    yonerge29.SetActive(true);   
    break;
    case 40:
    besgenalttaban.SetActive(false);
    besgenyanalalanlar.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge29.SetActive(false);
    yonerge30.SetActive(true);
    
    break;
    case 41:
    besgenyanalalanlar.SetActive(false);
    besgen1yanalalanlar2.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
    feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge30.SetActive(false);
    yonerge31.SetActive(true);
    
    
    break;
   case 42:
    besgen1yanalalanlar2.SetActive(false);
    besgen2yanalalanlar2.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge31.SetActive(false);
    yonerge32.SetActive(true);
   
    
    break;
    case 43:
    
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge32.SetActive(false);
    yonerge32soru.SetActive(true);
    
     break;
     case 44:
      besgen2yanalalanlar2.SetActive(false);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    altıgenısıklıprizma.SetActive(true);
    yonerge32soru.SetActive(false);
    yonerge33.SetActive(true);
   
    break;
   case 45:
     altıgenısıklıprizma.SetActive(false);
     altıgenprizmasol.SetActive(true);
     DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge33.SetActive(false);
    yonerge34.SetActive(true);
    
    break;
    case 46:
    
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge34soru.SetActive(true);
    yonerge34.SetActive(false);
    break;
    case 47:
    altıgenprizmasol.SetActive(false);
    altıgenkurdelaprizma.SetActive(true);
    
    yonerge34soru.SetActive(false);
    yonerge35.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    break;
    case 48:
    altıgenkurdelaprizma.SetActive(false);
    altıgenkurdelaprizmasol.SetActive(true);
    DevamButonu.SetActive(false);
    DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge35.SetActive(false);
    yonerge36.SetActive(true);
    break;
    case 49:
    DevamButonu.SetActive(false);
     DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge36.SetActive(false);
    yonerge36soru.SetActive(true);
    break;
    case 50:
    altıgenkurdelaprizmasol.SetActive(false);
    altıgenkoseli.SetActive(true);
    DevamButonu.SetActive(false);
     DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge36soru.SetActive(false);
    yonerge37.SetActive(true);
    break;
    case 51:
    altıgenkoseli.SetActive(false);
    altıgenkoselisol.SetActive(true);
     DevamButonu.SetActive(false);
     DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge37.SetActive(false);
    yonerge38.SetActive(true);
    break;
    case 52:
    DevamButonu.SetActive(false);
     DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge38.SetActive(false);
    yonerge38soru.SetActive(true);

   break;
   case 53:
   altıgenkoselisol.SetActive(false);
   altıgenalttaban.SetActive(true);
    DevamButonu.SetActive(false);
     DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge39.SetActive(true);
    yonerge38soru.SetActive(false);
    break;
    case 54:
    altıgenusttaban.SetActive(true);
    altıgenalttaban.SetActive(false);
     DevamButonu.SetActive(false);
     DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
     feedbackpositive.SetActive(true);
     feedbacknegative.SetActive(false);
     yonerge39.SetActive(false);
     yonerge40.SetActive(true);
     break;
     case 55:
     altıgenusttaban.SetActive(false);
     altıgenyanalalanlar.SetActive(true);
     altıgenalttaban.SetActive(false);
      DevamButonu.SetActive(false);
     DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge40.SetActive(false);
    yonerge41.SetActive(true);
     Debug.Log("55");
    break;
    case 56:
    altıgenyanalalanlar.SetActive(false);
    altıgen2yanalalanlar2.SetActive(true);
     DevamButonu.SetActive(false);
     DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge41.SetActive(false);
    yonerge42.SetActive(true);
    Debug.Log("56");
    break;
    case 57:
    DevamButonu.SetActive(false);
     DevamButonu_aktif.SetActive(true);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge42.SetActive(false);
    yonerge42soru.SetActive(true);
     Debug.Log("57");
    break;
    case 58:
    altıgen2yanalalanlar2.SetActive(false);
     DevamButonu.SetActive(false);
     DevamButonu_aktif.SetActive(false);
     feedback.SetActive(true);
    feedbackpositive.SetActive(true);
    feedbacknegative.SetActive(false);
    yonerge42soru.SetActive(false);
    yonerge43.SetActive(true);
    devamikinci.SetActive(true);
     Debug.Log("58");
    break;
   
     }


    



    }

}
