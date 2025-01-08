using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderScript : MonoBehaviour
{
    Transform cylinderTransform;
    Rigidbody cylinderRigidbody;
    Transform camTransform;
    float cylinderForce=5;
    float cylindermaxvelocity= 5;
    float cylinderjumpforce= 500;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        //cam=Camera.main
        camTransform =cam.transform;
        Debug.Log("oyun çalıştı");
        cylinderTransform =this.GetComponent<Transform>();
         cylinderRigidbody= this.GetComponent<Rigidbody>();
         

    }

    // Update is called once per frame
    void Update()
    {
        camTransform.position = new Vector3(cylinderTransform.position.x,camTransform.position.y,camTransform.position.z);
        //Debug.Log("frame updated");
       if(Input.GetKeyDown(KeyCode.RightArrow)){
          this.GetComponent<Transform>().position+= new Vector3(0.1f,0,0);
         cylinderRigidbody.AddForce(new Vector3(cylinderForce,0,0));
         // cylinderTransform.Translate(new Vector3(0.1f,0,0));
         Debug.Log(cylinderRigidbody.velocity);
         if (cylinderRigidbody.velocity.x<cylindermaxvelocity)
            cylinderRigidbody.AddForce(new Vector3(cylinderForce,0,0));
          
       }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        if( cylinderRigidbody.velocity.x > -1 * cylindermaxvelocity)
         cylinderRigidbody.AddForce(new Vector3(-1 * cylinderForce, 0, 0));
       

      if (!Input.GetKeyDown(KeyCode.RightArrow)&&!Input.GetKeyDown(KeyCode.LeftArrow)){

         // Debug.Log(Time.deltaTime);
          if(cylinderRigidbody.velocity.x>0.1f)
             cylinderRigidbody.velocity -= new Vector3(0.1f, 0,0);
           
        else if (cylinderRigidbody.velocity.x< -0.1f)
                    cylinderRigidbody.velocity += new Vector3(0.1f, 0,0);
        else cylinderRigidbody.velocity= new Vector3(0, cylinderRigidbody.velocity.y,0);

         if (Input.GetKeyDown(KeyCode.Space)){
             cylinderRigidbody.velocity= new Vector3(cylinderRigidbody.velocity.x, 0,0);
           cylinderRigidbody.AddForce(new Vector3(0,cylinderjumpforce,0));
      }   
      if(cylinderTransform.position.y<0)  {

Debug.Log("ÜZGÜNÜZ KAYBETTİNİZ");
GameObject.Destroy(this);


      }  
       }
    }
    void OnCollisionEnter(Collision col){

if (col.gameObject.name=="gold3"){

    Debug.Log( "TEBRİKLER OYUNU BİTİRDİNİZ!");
}
//Debug.Log(col.gameObject.name);

}
void OnTriggerEnter(Collider col){

Debug.Log("Tebrikler +1 puan kazandınız");
col.gameObject.SetActive(false);


}
}

