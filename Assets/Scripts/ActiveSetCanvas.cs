using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSetCanvas : MonoBehaviour
{
     public GameObject helpText;

 
     public void onClick() {
             helpText.SetActive(false);
     }
     public void onLost(){
         helpText.SetActive(true);
     }
}
