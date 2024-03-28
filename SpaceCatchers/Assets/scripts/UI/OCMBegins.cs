using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OCMBegins : MonoBehaviour
{
    public GameObject MainLogo;
    public GameObject[] menuText;
    public GameObject SplashBackround;
    public GameObject bgm;
    public GameObject GlobalScripts;
    public GameObject countingDownText;
    public GameObject TapButton;
    public GameObject FinalScore;
    public GameObject GameOverSound;
    public GameObject StartSound;
   
    void Start()
    {
        StartCoroutine(StartUpGame());
    }

    IEnumerator StartUpGame(){
        yield return new WaitForSeconds(1);
        StartSound.SetActive(true);
        MainLogo.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        MainLogo.SetActive(false);
        menuText[0].SetActive(true);
        TapButton.SetActive(true);
    }
    public void TapToStart(){
        TapButton.SetActive(false);
        menuText[0].SetActive(false);
        SplashBackround.GetComponent<Animator>().Play("SplashFadeOut");
        StartCoroutine(StartGame());
    }
    IEnumerator StartGame(){
        FinalScore.SetActive(false);
        SplashBackround.SetActive(false);
        yield return new WaitForSeconds(1);
        GameOverSound.SetActive(false);
        countingDownText.SetActive(true);
        yield return new WaitForSeconds(1);
        countingDownText.GetComponent<Text>().text = "2";
        yield return new WaitForSeconds(1);
        countingDownText.GetComponent<Text>().text = "1";
        yield return new WaitForSeconds(1);
        countingDownText.SetActive(false);
        countingDownText.GetComponent<Text>().text = "3";
        bgm.SetActive(true);
        SplashBackround.SetActive(false);
        GlobalScripts.GetComponent<Timer>().enabled = true;
        GlobalScripts.GetComponent<OrbGenerate>().enabled = true;
    }
}
