using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    private bool isInArea = false;

    private int uses = 10;

    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        if (collider2d == null)
        {
            return;
        }

        if (collider2d.gameObject == null)
        {
            return;
        }

        if (collider2d.gameObject.CompareTag("Player"))
        {
            isInArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider2d)
    {
        if (collider2d == null)
        {
            return;
        }

        if (collider2d.gameObject == null)
        {
            return;
        }

        if (collider2d.gameObject.CompareTag("Player"))
        {
            isInArea = false;
        }
    }

    private void Update()
    {
        if (uses <= 0)
        {
            return;
        }

        if (isInArea)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                uses = uses - 1;

                Inventory.gold = Inventory.gold+ 1;

                Debug.Log(Inventory.gold);
            }
        }
    }
}