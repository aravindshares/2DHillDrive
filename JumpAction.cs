using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAction : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D bike;

    public void JumpAct()
    {   
        bike.velocity = new Vector2(0, 7f);
    }
}
