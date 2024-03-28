using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject TimeDisplay;
    public bool countingDown = false;
    public int currentSeconds = 30;
    public bool isZero = false;
    public GameObject SplashBackround;
    public GameObject bgm;
    public GameObject GlobalScripts;
    public GameObject tapPlayButton;
    public GameObject FinalScore;
    public GameObject TapToBeginText;
    public GameObject GameOverSound;

    void Update()
    {
        if(countingDown == false && isZero == false)
        {
            countingDown = true;
            StartCoroutine(SubtractSecond());
        }
        if(isZero == true){
            
            FinalScore.GetComponent<Text>().text= "Score: "+ ScoreUpdater.orbScore;
            StartCoroutine(GameOver());
        }
    }

    IEnumerator SubtractSecond(){
        yield return new WaitForSeconds(1);
        currentSeconds -= 1;
        if(currentSeconds == 0){
            isZero = true;
        }
        TimeDisplay.GetComponent<Text>().text ="Time: "+ currentSeconds;
        countingDown = false;
    }
    IEnumerator GameOver(){
        GameOverSound.SetActive(true);
        SplashBackround.SetActive(true);
        SplashBackround.GetComponent<Animator>().Play("SplashFadeIn");
        bgm.SetActive(false);
        GlobalScripts.GetComponent<OrbGenerate>().enabled = false;
        yield return new WaitForSeconds(1.2f);
        FinalScore.SetActive(true);
        TapToBeginText.SetActive(true);
        tapPlayButton.SetActive(true); 
        currentSeconds = 31;
        isZero = false;
        ScoreUpdater.orbScore = 0;
        yield return new WaitForSeconds(0.1f);
        GlobalScripts.GetComponent<Timer>().enabled = false;

    }
}
