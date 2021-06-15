using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{   
    [HideInInspector]
    public int count;
    [SerializeField]
    Text counterText;
    [SerializeField]
    GameObject coinSound;

    void Update()
    {
        counterText.text = "X "+count;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag  == "Coin")
        {
            count++;
            Instantiate(coinSound);
            Destroy(col.gameObject);
        }
    }
}
