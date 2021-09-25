using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : MonoBehaviour
{
    public GameObject[] Build = new GameObject[1];


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Instantiate(Build[0], new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        Destroy(this.gameObject);
    }
}
