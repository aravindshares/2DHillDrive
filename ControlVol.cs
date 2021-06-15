using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ControlVol : MonoBehaviour
{
    [SerializeField]
    AudioMixer mastermix;
    public void SetVolLvl(float slidevalue)
    {
        mastermix.SetFloat("GamePlaySound", Mathf.Log10(slidevalue) * 20);
    }
}
