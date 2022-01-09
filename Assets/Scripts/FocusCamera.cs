using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Vuforia;
public class FocusCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        OnsingleTapped();
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
        OnsingleTapped();
    }
    private void OnsingleTapped(){
        TriggerAutoFocus();
    }
    public void TriggerAutoFocus(){
        StartCoroutine(TriggerAutoFocusAndEnableContinousFocusIfSet());
    }
    private IEnumerator TriggerAutoFocusAndEnableContinousFocusIfSet(){
        yield return new WaitForSeconds(0.5f);
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }
}
