using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// bhsjgdvfgv
public class Coin : MonoBehaviour
{
    public int value = 1;

    // comento porq el profe me lo dice
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<PlatformMovement>())
        {
            GameManager.instance.AddCoins(value);
            Debug.Log("Monedas: " + GameManager.instance.GetCoins());
            Destroy(gameObject);
        }
    }
}
