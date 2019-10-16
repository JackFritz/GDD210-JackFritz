using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillPlayer : MonoBehaviour
{
    public Text tellPlayer;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "dead")
        {
            tellPlayer.text = "Press R to Restart";
            Destroy(gameObject);
        }
    }
}
