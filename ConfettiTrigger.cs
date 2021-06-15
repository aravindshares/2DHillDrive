using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfettiTrigger : MonoBehaviour
{   [SerializeField]
    GameObject confetti, biker, celebrate, restart, exit, score, gamepad, pause, audios, particles, winmessage;
    [SerializeField]
    Text scorevalue;
    Counter scoredisplay;

    void Start()
    {
        scoredisplay = GameObject.FindObjectOfType<Counter>();
    }
    IEnumerator OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "ConTrig")
        {
            pause.SetActive(false);
            confetti.SetActive(true);
            winmessage.SetActive(true);
            audios.SetActive(false);
            particles.SetActive(false);
            celebrate.SetActive(true);
            yield return new WaitForSeconds(5);
            confetti.SetActive(false);
            biker.SetActive(false);
            gamepad.SetActive(false);
            score.SetActive(true);
            restart.SetActive(true);
            exit.SetActive(true);
            scorevalue.text = "SCORE: " + scoredisplay.count * 50;
        }
    }
}
