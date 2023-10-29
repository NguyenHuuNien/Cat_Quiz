using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<Controller_GUI>().incCountGem();
            this.gameObject.SetActive(false);
            FindObjectOfType<GameController>().incCountGem();
        }
    }
}
