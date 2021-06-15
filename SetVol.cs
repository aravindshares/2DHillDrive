using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVol : MonoBehaviour
{
    [SerializeField]
    AudioMixer mastermix;

    public void SetVolLvl(float slidevalue)
    {
        mastermix.SetFloat("MenuMusic", Mathf.Log10 (slidevalue) * 20);
    }
}
