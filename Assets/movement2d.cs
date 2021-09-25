using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2d : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float runSpeed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            CheckInteraction();
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

    public void OpenInteractableIcon()
    {
        //interactIcon.SetActive(true);
    }

    public void CloseInteractableIcon()
    {
        //interactIcon.SetActive(false);
    }

    public void CheckInteraction()
    {
        //RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position);
    }
}