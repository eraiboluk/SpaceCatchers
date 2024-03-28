using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCatch : MonoBehaviour
{
    public AudioSource OrbCatchFX;
    public AudioSource OrbBoomFX;

    void OnTriggerEnter(Collider other){
        
        if(other.tag == "RedOrb"){
            OrbCatchFX.Play();
            ScoreUpdater.orbScore += 6;
        }
        if(other.tag == "GreenOrb"){
            OrbCatchFX.Play();
            ScoreUpdater.orbScore += 4;
        }
        if(other.tag == "BlueOrb"){
            OrbCatchFX.Play();
            ScoreUpdater.orbScore += 2;
        }
        if(other.tag == "BlackOrb"){
            OrbBoomFX.Play();
            ScoreUpdater.orbScore += -3;
        }
        other.gameObject.SetActive(false);
    }
}
