using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionStrength : MonoBehaviour
{
    [SerializeField]
    ParticleSystem smokeemission;
    ForwardMovement emissionrate1;
    BackwardMovement emissionrate2;
    
    private void Start()
    {
        emissionrate1 = GameObject.FindObjectOfType<ForwardMovement>();
        emissionrate2 = GameObject.FindObjectOfType<BackwardMovement>();
    }
    private void Update()
    {
        if (emissionrate1.emissionStrengthF == 1 || emissionrate2.emissionStrengthB ==1)
        {
            var emit = smokeemission.emission;
            emit.rateOverTime = 10f;
        }
        if (emissionrate1.emissionStrengthF == 5 || emissionrate2.emissionStrengthB == 5)
        {
            var emit = smokeemission.emission;
            emit.rateOverTime = 50f;
        }
    }
}
