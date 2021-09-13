using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaiterDest : MonoBehaviour
{
  public int pivotPoint;


  void OnTriggerEnter(Collider other) 
  {
      if(other.tag == "NPC")
      {

           if(pivotPoint == 2)
          {
              this.gameObject.transform.position = new Vector3(-10.279f, 6.573f, -9.842f);
              pivotPoint = 0;
          }

          if(pivotPoint == 1)
          {
              this.gameObject.transform.position = new Vector3(-11.24f, 2.23f, -11.3f);
              pivotPoint = 2;
          }
          
          if(pivotPoint == 0)
          {
              this.gameObject.transform.position = new Vector3(-10.279f, 6.573f, -9.842f);
              pivotPoint = 1;
          }
      }    
  }
}

/*
      if(pivotPoint == 6)
          {
              pivotPoint = 0;
          }

           if(pivotPoint == 5)
          {
              this.gameObject.transform.position = new Vector3(-3.441f,  3.542f, -2.402f);
              pivotPoint = 6;
          }

           if(pivotPoint == 4)
          {
              this.gameObject.transform.position = new Vector3(-1.242f, -2.453f, - 0.265f);
              pivotPoint = 5;
          }

           if(pivotPoint == 3)
          {
              this.gameObject.transform.position = new Vector3(3.788f, -2.319f, - 0.265f);
              pivotPoint = 4;
          }

           if(pivotPoint == 2)
          {
              this.gameObject.transform.position = new Vector3(1.823f, -2.319f, -4.977f);
              pivotPoint = 3;
          }


          if(pivotPoint == 1)
          {
              this.gameObject.transform.position = new Vector3(3.788f,  -2.319f, -4.977f);
              pivotPoint = 2;
          }
          
          if(pivotPoint == 0)
          {
              this.gameObject.transform.position = new Vector3(-0.528f,  2.387f, 1.943f);
              pivotPoint = 1;
          }
*/