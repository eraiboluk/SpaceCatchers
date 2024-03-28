using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFunctions : MonoBehaviour
{
    public GameObject LeftPlatform;
    public GameObject MiddlePlatform;
    public GameObject RightPlatform;
    public int activePlat = 0;
    public AudioSource platActiveFX;

    public void LeftPlat(){
        if (activePlat <= 1){
            activePlat++;
            platActiveFX.Play();
            LeftPlatform.SetActive(true);
            StartCoroutine(LeftReset());
        }
    }
    public void MidPlat(){
        if (activePlat <= 1){
            activePlat++;
            platActiveFX.Play();
            MiddlePlatform.SetActive(true);
            StartCoroutine(MidReset());
        }
    }
    public void RightPlat(){
        if (activePlat <= 1){
            activePlat++;
            platActiveFX.Play();
            RightPlatform.SetActive(true);
            StartCoroutine(RightReset());
        }
    }
    IEnumerator LeftReset(){
        yield return new WaitForSeconds(0.25f);
        LeftPlatform.SetActive(false);
        activePlat--;
    }
    IEnumerator MidReset(){ 
        yield return new WaitForSeconds(0.25f);
        MiddlePlatform.SetActive(false);
        activePlat--;
    }
    IEnumerator RightReset(){
        yield return new WaitForSeconds(0.25f);
        RightPlatform.SetActive(false);
        activePlat--;
    }
}
