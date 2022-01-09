using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSet : MonoBehaviour
{
    public GameObject helpText;
    public GameObject helpText2;
 
     void Start() {
         helpText.SetActive(false);
         helpText2.SetActive(false);
     }
 
     public void onClick() {
         if(helpText.activeSelf) {
             helpText.SetActive(false);
         }
         else {
             helpText.SetActive(true);
             helpText2.SetActive(false);
         }
     }
     public void onClick2(){
         if(helpText2.activeSelf) {
             helpText2.SetActive(false);
         }
         else {
             helpText.SetActive(false);
             helpText2.SetActive(true);
         }
     }
}
