using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class Bant : MonoBehaviour, IEndDragHandler, IDragHandler
{
    public GameObject kenar1Bant, kenar2Bant, kenar3Bant, kenar4Bant, kenar5Bant, kenar6Bant, kenar7Bant, kenar8Bant, kenar9Bant, kenar10Bant;

    public GameObject kenar1Kurdele, kenar2Kurdele, kenar3Kurdele, kenar4Kurdele;
    public GameObject d3genkenar1kurdeleli, d3genkenar2kurdeleli,d3genkenar3kurdeleli;
    public GameObject kose1ucgen,kose2ucgen,kose3ucgen,kose4ucgen,kose5ucgen,kose6ucgen;
    public GameObject ucgenalttaban,ucgenusttaban,ucgenyanal1,ucgenyanal2,ucgenyanal3;
    public GameObject kose1,kose2,kose3,kose4,kose5,kose6,kose7,kose8;
    public GameObject yanal1,yanal2,yanal3,yanal4;
    public GameObject alttaban,usttaban;
    public GameObject kenar1ucgen,kenar2ucgen,kenar3ucgen,kenar4ucgen,kenar6ucgen,kenar5ucgen;
    
    public GameObject DevamButonu_aktif, DevamButonu;
    public GameObject isikliPrizma,isikliprizmasol,kurdelaprizma,kurdelaprizmasol,koseliprizma,koseliprizmadevrik, feedback;
    public GameObject dprizmaalttaban,dprizmausttaban,dprizmayanal1,dprizmayanal2;
    public GameObject besgenkenar1,besgenkenar2,besgenkenar3,besgenkenar4,besgenkenar5,besgenkenar6,besgenkenar7,besgenkenar8,besgenkenar9,besgenkenar10;
    public GameObject besgenkurdele1,besgenkurdele2,besgenkurdele3,besgenkurdele4,besgenkurdele5;
    public GameObject besgenkose1,besgenkose2,besgenkose3,besgenkose4,besgenkose5,besgenkose6,besgenkose7,besgenkose8,besgenkose9,besgenkose10;
    public GameObject besgenusttaban,besgenalttaban,besgenyanal1,besgenyanal2,besgenyanal3,besgenyanal4,besgenyanal5;
    public GameObject altıgenkenar1,altıgenkenar2,altıgenkenar3,altıgenkenar4,altıgenkenar5,altıgenkenar6;
    public GameObject altıgenkenar7,altıgenkenar8,altıgenkenar9,altıgenkenar10,altıgenkenar11,altıgenkenar12;
    public GameObject altıgenkurdele1,altıgenkurdele2,altıgenkurdele3,altıgenkurdele4,altıgenkurdele5,altıgenkurdele6;
    public GameObject altıgenkose1,altıgenkose2,altıgenkose3,altıgenkose4,altıgenkose5,altıgenkose6;
    public GameObject altıgenkose7, altıgenkose8,altıgenkose9,altıgenkose10,altıgenkose11,altıgenkose12;
    public GameObject altıgenusttaban, altıgenalttaban,altıgenyanal1,altıgenyanal2,altıgenyanal3,altıgenyanal4,altıgenyanal5,altıgenyanal6;
    private RectTransform rectTransform;
    public Vector3 bantPos;
    public int a=11,b=11,c=11,d=11;
    public int e=11,f=11,g=11,h=11;
    public int x=11, y=11, z=11,t=11;
    public int xx=11, yy=11, zz=11,tt=11;
    public int p=11,r=11,s=11,q=11;
    public int pp=11,rr=11,ss=11,qq=11;
    public int i=11, j=11, k=11,l=11;
    public int aa=11,bb=11,cc=11,dd=11,ee=11,ff=11;
    public int aaa=11,bbb=11, ccc=11,ddd=11,eee=11;
    public int bs=11,bt=11,by=11,bz=11,bx=11;
    public int xxxx=11,yyyy=11,zzzz=11,pppp=11,rrrr=11,tttt=11;
    public int cx=11, ct=11,cy=11,cz=11, cp=11, cr=11,ck=11,cl=11,cm=11;
    public int dx=11,dy=11,dz=11,dt=11,dp=11,dr=11;
    public int kx=11,ky=11,kz=11,kt=11,kp=11;
    public int ox=11,oy=11,oz=11,ux=11,uy=11,uz=11,ex=11,ey=11,ez=11,vx=11,vy=11,vz=11,jx=11,jy=11,jz=11;
   public int ua=11;
   public int qx=11,qy=11,qz=11,qt=11,qp=11;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        bantPos = rectTransform.position;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        rectTransform.position = bantPos;
        Debug.Log("OnEndDrag");
    }


    void OnTriggerEnter2D(Collider2D other)
    {
       
        if(other.tag == "kenar1Bant")
        {
            kenar1Bant.SetActive(true);
            other.tag = "kenar1BantVar";
            a=1;
            
        }
          

        if (other.tag == "kenar2Bant")
        {
            kenar2Bant.SetActive(true);
            other.tag ="kenar2BantVar";
            b=1;
            
        }

        if (other.tag == "kenar3Bant")
        {
            kenar3Bant.SetActive(true);
            other.tag = "kenar3BantVar";
           c=1;
            
        }

        if (other.tag == "kenar4Bant")
        {
            kenar4Bant.SetActive(true);
            other.tag = "kenar4BantVar";
            
        }

        if (other.tag == "kenar5Bant")
        {
            kenar5Bant.SetActive(true);
            other.tag = "kenar5BantVar";
            d=1;
        }
          if ((a==1) && (b==1) && (c==1) && (d==1) )
        {
            
            DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            a=0; b=0;c=0;d=0;
          
        }
      //  if(other.tag=="DevamButonu_aktif"){

         //  DevamButonu.SetActive(true);
         //  DevamButonu_aktif.SetActive(false);


       // }
      
    
     
         if (other.tag == "kenar7Bant")
        {
            kenar7Bant.SetActive(true);
            other.tag = "kenar7BantVar";
            e=1;
        }

        if (other.tag == "kenar8Bant")
        {
            kenar8Bant.SetActive(true);
            other.tag = "kenar8BantVar";
            f=1;
        }

        if (other.tag == "kenar9Bant")
        {
            kenar9Bant.SetActive(true);
            other.tag = "kenar9BantVar";
            g=1;
        }

        if (other.tag == "kenar10Bant")
        {
            kenar10Bant.SetActive(true);
            other.tag = "kenar10BantVar";
            h=1;
        }
      if((e==1) && (f==1) && (g==1) && (h==1)){

            
            DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            
            
           e=0; f=0; g=0; h=0;

        }

      
      
       

        if (other.tag == "kenar1Kurdele")
        {
            kenar1Kurdele.SetActive(true);
            other.tag= "kenar1KurdeleVar";
            x=1;
        }

        if (other.tag == "kenar2Kurdele")
        {
            kenar2Kurdele.SetActive(true);
            other.tag=" kenar2KurdeleVar";
            y=1;
        }

        if (other.tag == "kenar3Kurdele")
        {
            kenar3Kurdele.SetActive(true);
            other.tag= "kenar3KurdeleVar";
            z=1;
        }
        if((x==1)&& (y==1)&& (z==1)){
         DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
           
        x=0; y=0; z=0;

        }
        
        
        if (other.tag == "kenar4Kurdele")
        {
            kenar4Kurdele.SetActive(true);
            other.tag = "kenar4KurdeleVar";
            t=1;
            
            
        }
        if((t==1)){

        DevamButonu.SetActive(false);
        DevamButonu_aktif.SetActive(true);
        
        t=0;

        }
         
         if (other.tag == "kose1")
        {
            kose1.SetActive(true);
            other.tag= "kose1Var";
            p=1;
        }

        if (other.tag == "kose2")
        {
            kose2.SetActive(true);
            other.tag="kose2var";
            r=1;
        }

        if (other.tag == "kose3")
        {
            kose3.SetActive(true);
            other.tag="kose3var";
            s=1;
        }

        if (other.tag == "kose4")
        {
            kose4.SetActive(true);
            other.tag="kose4var";
            q=1;
        }
        if((p==1)&&(r==1)&&(s==1)&&(q==1)){
            DevamButonu.SetActive(false);
        DevamButonu_aktif.SetActive(true);
        
       p=0; r=0; s=0;q=0;


        }
         if (other.tag == "kose5")
        {
            kose5.SetActive(true);
            other.tag="kose5var";
            i=1;
        }

        if (other.tag == "kose6")
        {
            kose6.SetActive(true);
            other.tag= "kose6var";
            j=1;
        }

        if (other.tag == "kose7")
        {
            kose7.SetActive(true);
            other.tag="kose7var";
            k=1;
        }

        if (other.tag == "kose8")
        {
            kose8.SetActive(true);
            other.tag= "kose8var";
            l=1;
        }
        if((i==1)&&(j==1)&&(k==1)&&(l==1)){

        DevamButonu.SetActive(false);
        DevamButonu_aktif.SetActive(true);
       
        i=0; j=0; k=0; l=0;



        }
         if (other.tag == "alttaban")
        {
            alttaban.SetActive(true);
            other.tag= "alttabanvar";
            aa=1;
        }
        if(aa==1){

         DevamButonu.SetActive(false);
        DevamButonu_aktif.SetActive(true);
        aa=0;


        }
        if (other.tag == "usttaban")
        {
            usttaban.SetActive(true);
            other.tag= "usttabanvar";
            bb=1;
        }
        if(bb==1){

         DevamButonu.SetActive(false);
        DevamButonu_aktif.SetActive(true);
        bb=0;


        }
        if (other.tag == "yanal1")
        {
            yanal1.SetActive(true);
            other.tag= "yanal1var";
            cc=1;
        }
         if (other.tag == "yanal2")
        {
            yanal2.SetActive(true);
            other.tag= "yanal2var";
            dd=1;
        }
        if((cc==1)&&(dd==1)){
      
         DevamButonu.SetActive(false);
        DevamButonu_aktif.SetActive(true);
        cc=0;dd=0;


        }
         if (other.tag == "yanal3")
        {
            yanal3.SetActive(true);
            other.tag="yanal3var";
            ee=1;
        }
        if (other.tag == "yanal4")
        {
            yanal4.SetActive(true);
            other.tag="yanal4var";
            ff=1;
        }
        if((ee==1)&&(ff==1)){
      
         DevamButonu.SetActive(false);
        DevamButonu_aktif.SetActive(true);
        ee=0;ff=0;


        }
         if (other.tag == "kenar1ucgen")
        {
            kenar1ucgen.SetActive(true);
            other.tag= "ucgen1var";
            ox=1;
        }
         if (other.tag == "kenar2ucgen")
        {
            kenar2ucgen.SetActive(true);
            other.tag="ucgen2var";
            oy=1;
        }
        if (other.tag == "kenar3ucgen")
        {
            kenar3ucgen.SetActive(true);
            other.tag="ucgen3var";
            oz=1;
        }
        if((ox==1)&&(oy==1)&&(oz==1)){
        DevamButonu.SetActive(false);
        DevamButonu_aktif.SetActive(true);
        ox=0;
        oy=0;
        oz=0;

        }
        if (other.tag == "kenar4ucgen")
        {
            kenar4ucgen.SetActive(true);
            other.tag= "ucgen4var";
            ux=1;
        }
         if (other.tag == "kenar5ucgen")
        {
            kenar5ucgen.SetActive(true);
            other.tag="ucgen5var";
            uy=1;
        }
        if (other.tag == "kenar6ucgen")
        {
            kenar6ucgen.SetActive(true);
            other.tag="ucgen6var";
            uz=1;
        }
        if((ux==1)&&(uy==1)&&(uz==1)){
        DevamButonu.SetActive(false);
        DevamButonu_aktif.SetActive(true);
        ux=0;
        uy=0;
        uz=0;
        }
        if (other.tag == "kenar1kurdeleli")
        {
            d3genkenar1kurdeleli.SetActive(true);
            other.tag="kurdele1var";
            ex=1;
        }
        if (other.tag == "kenar2kurdeleli")
        {
            d3genkenar2kurdeleli.SetActive(true);
            other.tag="kurdele2var";
            ey=1;
        }
        if((ex==1)&&(ey==1)){
        DevamButonu.SetActive(false);
        DevamButonu_aktif.SetActive(true);
        ex=0;
       ey=0;
        }
        if (other.tag == "kenar3kurdeleli")
        {
            d3genkenar3kurdeleli.SetActive(true);
            other.tag="kurdele3var";
            ez=1;
        }
        if(ez==1){
        DevamButonu.SetActive(false);
        DevamButonu_aktif.SetActive(true);
        ez=0;
        }
         if (other.tag == "kose1ucgen")
        {
            kose1ucgen.SetActive(true);
            other.tag="raptiye1var";
            vx=1;
        }
         if (other.tag == "kose2ucgen")
        {
            kose2ucgen.SetActive(true);
            other.tag="raptiye2var";
            vy=1;
        }
         if (other.tag == "kose3ucgen")
        {
            kose3ucgen.SetActive(true);
            other.tag="raptiye3var";
            vz=1;
        }
         if((vx==1)&&(vy==1)&&(vz==1)){
        DevamButonu.SetActive(false);
        DevamButonu_aktif.SetActive(true);
        vx=0;
        vy=0;
        vz=0;
        }
         if (other.tag == "kose4ucgen")
        {
            kose4ucgen.SetActive(true);
            other.tag="raptiye4var";
            jx=1;
        }
        
         if (other.tag == "kose5ucgen")
        {
            kose5ucgen.SetActive(true);
            other.tag="raptiye5var";
            jy=1;
        }
         if (other.tag == "kose6ucgen")
        {
            kose6ucgen.SetActive(true);
            other.tag="raptiye6var";
            jz=1;
        }
         if((jx==1)&&(jy==1)&&(jz==1)){
        DevamButonu.SetActive(false);
        DevamButonu_aktif.SetActive(true);
        jx=0;
        jy=0;
        jz=0;
        }
        
         if (other.tag == "ucgenalttaban")
        {
            ucgenalttaban.SetActive(true);
            other.tag="alttabanvar";
            ua=1;
           
        }
         if ((ua==1) )
        {
            
            DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            ua=0; 
          
        }
          if (other.tag == "ucgenusttaban")
        {
            ucgenusttaban.SetActive(true);
            other.tag="usttabanvar";
            ky=1;
        }
         if ((ky==1) )
        {
            
            DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            ky=0; 
          
        }
         if (other.tag == "ucgenyanal1")
        {
            ucgenyanal1.SetActive(true);
            other.tag="ucgenyanal1var";
            kz=1;
        }
         if ((kz==1) )
        {
            
            DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            kz=0; 
          
        }

         if (other.tag == "ucgenyanal2")
        {
            ucgenyanal2.SetActive(true);
            other.tag="ucgenyanal2var";
            kt=1;
        }
         if ((kt==1) )
        {
            
            DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            kt=0; 
          
        }
         if (other.tag == "ucgenyanal3")
        {
            ucgenyanal3.SetActive(true);
            other.tag="ucgenyanal3var";
            kp=1;
        }
         if ((kp==1) )
        {
            
            DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            kp=0; 
          
        }
         if (other.tag == "besgenkenar1")
        {
            besgenkenar1.SetActive(true);
            other.tag="besgenkenar1var";
            aaa=1;
        }
        if (other.tag == "besgenkenar2")
        {
            besgenkenar2.SetActive(true);
            other.tag="besgenkenar2var";
            bbb=1;
        }
        if (other.tag == "besgenkenar3")
        {
            besgenkenar3.SetActive(true);
            other.tag="besgenkenar3var";
            ccc=1;
        }
        if (other.tag == "besgenkenar4")
        {
            besgenkenar4.SetActive(true);
            other.tag="besgenkenar4var";
            ddd=1;
        }
        if (other.tag == "besgenkenar5")
        {
            besgenkenar5.SetActive(true);
            other.tag="besgenkenar5var";
            eee=1;
        }
        if((aaa==1)&&(bbb==1)&&(ccc==1)&&(ddd==1)&&(eee==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            a=0;
            b=0;
            c=0;
            d=0;
            e=0; 

        }
        if (other.tag == "besgenkenar6")
        {
            besgenkenar6.SetActive(true);
            other.tag="besgenkenar6var";
            qx=1;
        }
        if (other.tag == "besgenkenar7")
        {
            besgenkenar7.SetActive(true);
            other.tag="besgenkenar7var";
            qy=1;
        }
        if (other.tag == "besgenkenar8")
        {
            besgenkenar8.SetActive(true);
            other.tag="besgenkenar8var";
            qz=1;
        }
        if (other.tag == "besgenkenar9")
        {
            besgenkenar9.SetActive(true);
            other.tag="besgenkenar9var";
            qt=1;
        }
        if (other.tag == "besgenkenar10")
        {
            besgenkenar10.SetActive(true);
            other.tag="besgenkenar10var";
            qp=1;
        }
        if((qx==1)&&(qy==1)&&(qz==1)&&(qt==1)&&(qp==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            qx=0;
            qy=0;
            qz=0;
            qt=0;
            qp=0; 

        }
        //besgen dik prizma kurdeleleme
         if (other.tag == "besgenkurdele1")
        {
            besgenkurdele1.SetActive(true);
            other.tag="besgenkurdele1var";
            xx=1;
        }
         if (other.tag == "besgenkurdele2")
        {
            besgenkurdele2.SetActive(true);
            other.tag="besgenkurdele2var";
            yy=1;
        }
         if (other.tag == "besgenkurdele3")
        {
            besgenkurdele3.SetActive(true);
            other.tag="besgenkurdele3var";
            zz=1;
        }
          if((xx==1)&&(yy==1)&&(zz==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            xx=0;
            yy=0;
            zz=0;
           

        }
         if (other.tag == "besgenkurdele4")
        {
            besgenkurdele4.SetActive(true);
            other.tag="besgenkurdele4var";
            tt=1;
        }
         if (other.tag == "besgenkurdele5")
        {
            besgenkurdele5.SetActive(true);
            other.tag="besgenkurdele5var";
            pp=1;
        }
          if((pp==1)&&(tt==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            pp=0;
            tt=0;
           

        }
        // besgen dik prizma raptiyeleme
        if (other.tag == "besgenkose1")
        {
            besgenkose1.SetActive(true);
            other.tag="besgenkose1var";
            rr=1;
        }
        if (other.tag == "besgenkose2")
        {
            besgenkose2.SetActive(true);
            other.tag="besgenkose2var";
            ss=1;
        }
        if (other.tag == "besgenkose3")
        {
            besgenkose3.SetActive(true);
            other.tag="besgenkose3var";
            zz=1;
        }
        if (other.tag == "besgenkose4")
        {
            besgenkose4.SetActive(true);
            other.tag="besgenkose4var";
            tt=1;
        }
        if (other.tag == "besgenkose5")
        {
            besgenkose5.SetActive(true);
            other.tag="besgenkose5var";
            xx=1;
        }
         if((rr==1)&&(ss==1)&&(zz==1)&&(tt==1)&&(xx==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            xx=0;
            yy=0;
            zz=0;
            tt=0;
            rr=0; 

        }
        if (other.tag == "besgenkose6")
        {
            besgenkose6.SetActive(true);
            other.tag="besgenkose6var";
            rr=1;
        }
        if (other.tag == "besgenkose7")
        {
            besgenkose7.SetActive(true);
            other.tag="besgenkose7var";
            ss=1;

        }
        if (other.tag == "besgenkose8")
        {
            besgenkose8.SetActive(true);
            other.tag="besgenkose8var";
            zz=1;
        }
        if (other.tag == "besgenkose9")
        {
            besgenkose9.SetActive(true);
            other.tag="besgenkose9var";
            tt=1;
        }
        if (other.tag == "besgenkose10")
        {
            besgenkose10.SetActive(true);
            other.tag="besgenkose10var";
            yy=1;
        }
        if((rr==1)&&(ss==1)&&(zz==1)&&(tt==1)&&(yy==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            ss=0;
            yy=0;
            zz=0;
            tt=0;
            rr=0; 

        }
        //besgen alt ve ust taban
         if (other.tag == "besgenusttaban")
        {
            besgenusttaban.SetActive(true);
            other.tag="besgenusttabanvar";
            bs=1;
        }
        if(bs==1){
          DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            bs=0;

        }
         if (other.tag == "besgenalttaban")
        {
            besgenalttaban.SetActive(true);
            other.tag="besgenalttabanvar";
            bt=1;
        }
          if(bt==1){
          DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            bt=0;

        }
        //besgen prizma yanal alanlar
         if (other.tag == "besgenyanal1")
        {
            besgenyanal1.SetActive(true);
            other.tag="besgenyanal1var";
            bx=1;
        }
         if (other.tag == "besgenyanal2")
        {
            besgenyanal2.SetActive(true);
            other.tag="besgenyanal2var";
            by=1;
        }
        if((bx==1)&&(by==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
             bx=0;
            by=0; 

        }
         if (other.tag == "besgenyanal3")
        {
            besgenyanal3.SetActive(true);
            other.tag="besgenyanal3var";
            zz=1;
        }
         if (other.tag == "besgenyanal4")
        {
            besgenyanal4.SetActive(true);
            other.tag="besgenyanal4var";
            bx=1;
        }
         if (other.tag == "besgenyanal5")
        {
            besgenyanal5.SetActive(true);
            other.tag="besgenyanal5var";
            pp=1;
        }
        if(pp==1){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            pp=0;

        }
        if((bx==1)&&(zz==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
             bx=0;
            zz=0; 
           

        }
        //altıgen prizma kenar ayrıtları
        if (other.tag == "altıgenkenar1")
        {
            altıgenkenar1.SetActive(true);
            other.tag="altıgenkanr1var";
            xxxx=1;
        }
         if (other.tag == "altıgenkenar2")
        {
            altıgenkenar2.SetActive(true);
            other.tag="altıgenkanr2var";
            yyyy=1;
        }
         if (other.tag == "altıgenkenar3")
        {
            altıgenkenar3.SetActive(true);
            other.tag="altıgenkanr3var";
            zzzz=1;
        }
         if (other.tag == "altıgenkenar4")
        {
            altıgenkenar4.SetActive(true);
            other.tag="altıgenkanr4var";
            tttt=1;
        }
         if (other.tag == "altıgenkenar5")
        {
            altıgenkenar5.SetActive(true);
            other.tag="altıgenkanr5var";
            pppp=1;
        }
         if (other.tag == "altıgenkenar6")
        {
            altıgenkenar6.SetActive(true);
            other.tag="altıgenkanr6var";
            rrrr=1;
        
        }
         if((xxxx==1)&&(yyyy==1)&&(zzzz==1)&&(tttt==1)&&(pppp==1)&&(rrrr==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            xxxx=0;
            yyyy=0;
            zzzz=0;
            tttt=0;
            pppp=0;
            rrrr=0;


        }

         if (other.tag == "altıgenkenar7")
        {
            altıgenkenar7.SetActive(true);
            other.tag="altıgenkanr7var";
            xxxx=1;
        }
         if (other.tag == "altıgenkenar8")
        {
            altıgenkenar8.SetActive(true);
            other.tag="altıgenkenar8var";
            yyyy=1;
        }
         if (other.tag == "altıgenkenar9")
        {
            altıgenkenar9.SetActive(true);
            other.tag="altıgenkanr9var";
            zzzz=1;
        }
          if (other.tag == "altıgenkenar10")
        {
            altıgenkenar10.SetActive(true);
            other.tag="altıgenkenar10var";
            tttt=1;
        }  if (other.tag == "altıgenkenar11")
        {
            altıgenkenar11.SetActive(true);
            other.tag="altıgenkenar11var";
            pppp=1;
        }
          if (other.tag == "altıgenkenar12")
        {
            altıgenkenar12.SetActive(true);
            other.tag="altıgenkenar12var";
            aa=1;
        }
        if((xxxx==1)&&(yyyy==1)&&(zzzz==1)&&(tttt==1)&&(pppp==1)&&(aa==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            xxxx=0;
            yyyy=0;
            zzzz=0;
            tttt=0;
            pppp=0;
            aa=0;


        }
        //altıgen prizma kurdeleleme 
          if (other.tag == "altıgenkurdele1")
        {
            altıgenkurdele1.SetActive(true);
            other.tag="altıgenkurdele1";
            cx=1;
        }
         if (other.tag == "altıgenkurdele2")
        {
            altıgenkurdele2.SetActive(true);
            other.tag="altıgenkurdele2";
            cy=1;
        }
         if (other.tag == "altıgenkurdele3")
        {
            altıgenkurdele3.SetActive(true);
            other.tag="altıgenkurdele3";
            cz=1;
        }
         if (other.tag == "altıgenkurdele4")
        {
            altıgenkurdele4.SetActive(true);
            other.tag="altıgenkurdele4";
            ct=1;
        }
        if((cx==1)&&(cy==1)&&(cz==1)&&(ct==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            cx=0;
            cy=0;
            cz=0;
            ct=0;

        }
         if (other.tag == "altıgenkurdele5")
        {
            altıgenkurdele5.SetActive(true);
            other.tag="altıgenkurdele5";
            cp=1;
        }
        
         if (other.tag == "altıgenkurdele6")
        {
            altıgenkurdele6.SetActive(true);
            other.tag="altıgenkurdele6";
            cr=1;
        }
        if((cp==1)&&(cr==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
          cp=0;
          cr=0;


        }
        //altıgen prizma raptiyeleme
        if (other.tag == "altıgenkose1")
        {
            altıgenkose1.SetActive(true);
            other.tag="altıgenkose1var";
            cm=1;
        }
        if (other.tag == "altıgenkose2")
        {
            altıgenkose2.SetActive(true);
            other.tag="altıgenkose2var";
            cy=1;
        }
        if (other.tag == "altıgenkose3")
        {
            altıgenkose3.SetActive(true);
            other.tag="altıgenkose3var";
            cz=1;
        }
        if (other.tag == "altıgenkose4")
        {
            altıgenkose4.SetActive(true);
            other.tag="altıgenkose4var";
            ct=1;
        }
        if (other.tag == "altıgenkose5")
        {
            altıgenkose5.SetActive(true);
            other.tag="altıgenkose5var";
            ck=1;
        }
        if (other.tag == "altıgenkose6")
        {
            altıgenkose6.SetActive(true);
            other.tag="altıgenkose6var";
            cl=1;
        }
        if((ck==1)&&(cl==1)&&(cm==1)&&(cy==1)&&(cz==1)&&(ct==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
          ck=0;
          cl=0;
          cm=0;
          cy=0;
          cz=0;
          ct=0;

        }
        if (other.tag == "altıgenkose7")
        {
            altıgenkose7.SetActive(true);
            other.tag="altıgenkose7var";
            ck=1;
        }
        if (other.tag == "altıgenkose8")
        {
            altıgenkose8.SetActive(true);
            other.tag="altıgenkose8var";
            cl=1;
        }
        if (other.tag == "altıgenkose9")
        {
            altıgenkose9.SetActive(true);
            other.tag="altıgenkose9var";
            cm=1;
        }
        if (other.tag == "altıgenkose10")
        {
            altıgenkose10.SetActive(true);
            other.tag="altıgenkose10var";
            cy=1;
        }
        if (other.tag == "altıgenkose11")
        {
            altıgenkose11.SetActive(true);
            other.tag="altıgenkose11var";
            cz=1;
        }
        if (other.tag == "altıgenkose12")
        {
            altıgenkose12.SetActive(true);
            other.tag="altıgenkose12var";
            cr=1;
        }
        if((ck==1)&&(cl==1)&&(cm==1)&&(cy==1)&&(cz==1)&&(cr==1)){
        DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
          ck=0;
          cl=0;
          cm=0;
          cy=0;
          cz=0;
          cr=0;

        }
        //altıgen prizma alt ve üst taban
         if (other.tag == "altıgenusttaban")
        {
            altıgenusttaban.SetActive(true);
            other.tag="altıgenusttabanvar";
            dx=1;
        }
         if (other.tag == "altıgenalttaban")
        {
            altıgenalttaban.SetActive(true);
            other.tag="altıgenalttabanvar";
            dx=1;
        }
        if(dx==1){
         DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            dx=0;


        }
        //altıgen yanal alanlar
          if (other.tag == "altıgenyanal1")
        {
            altıgenyanal1.SetActive(true);
            other.tag="altıgenyanal1var";
            dx=1;
        }
         if (other.tag == "altıgenyanal2")
        {
            altıgenyanal2.SetActive(true);
            other.tag="altıgenyanal2var";
            dy=1;
        }
         if (other.tag == "altıgenyanal3")
        {
            altıgenyanal3.SetActive(true);
            other.tag="altıgenyanal3var";
            dz=1;
        }
         if((dx==1)&&(dy==1)&&(dz==1)){
         DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            dx=0;
            dy=0;
            dz=0;

        }
         if (other.tag == "altıgenyanal4")
        {
            altıgenyanal4.SetActive(true);
            other.tag="altıgenyanal4var";
            dx=1;
        }
         if (other.tag == "altıgenyanal5")
        {
            altıgenyanal5.SetActive(true);
            other.tag="altıgenyanal5var";
            dy=1;
        }
         if (other.tag == "altıgenyanal6")
        {
            altıgenyanal6.SetActive(true);
            other.tag="altıgenyanal6var";
            dp=1;
        }
        if((dx==1)&&(dy==1)&&(dp==1)){
         DevamButonu.SetActive(false);
            DevamButonu_aktif.SetActive(true);
            dx=0;
            dy=0;
            dp=0;

        }
    } 
  

    void OnTriggerExit2D(Collider2D other)
    {
        //   isikliPrizma.SetActive(true);
       // buyutecliPrizma.SetActive(false);
        Debug.Log("OnTriggerExit2D  " + other.name);
    }

   
}