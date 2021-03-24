using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public float player_health;
    public GameObject Player;
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            player_health -= 5f;
            if (player_health == 0f)
            {
                Destroy(Player);
            }
        }
    }
}
