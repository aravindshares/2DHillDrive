using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D frntWheel, backWheel, bikeRigid;
    [SerializeField]
    GameObject AudioSet1, AudioSet2;
    float speed = 10f;
    public int emissionStrengthF = 1;
    bool isPressed = false;
   
    private void FixedUpdate()
    {
        if (isPressed && bikeRigid.velocity.x < 15)
        {
            frntWheel.AddForce(new Vector2(speed, 0));
            backWheel.AddForce(new Vector2(speed, 0));
        }
    }
    public void ButtonPress()
    {
        isPressed = true;
        AudioSet1.SetActive(false);
        AudioSet2.SetActive(true);
        emissionStrengthF = 5;
    }
    public void ButtonRelease()
    {
        isPressed = false;
        AudioSet2.SetActive(false);
        AudioSet1.SetActive(true);
        emissionStrengthF = 1;
    }
}
