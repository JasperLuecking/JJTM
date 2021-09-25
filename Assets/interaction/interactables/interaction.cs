using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public float maxSelectDistance = 25f;
    bool isFocus = false;
    Transform player;
    bool hasInteracted = false;
    public GameObject cursorImage;
    public GameObject mainCameraObject;
    public Renderer selectedObject;
    Camera cam;
    Vector3 heightOffsetPos;
    Vector3 screenPos;
    Vector3 twoDimPos;

    void Start()
    {
        isFocus = false;
        player = GameObject.Find("MouseKnight").transform;
        cursorImage = GameObject.FindWithTag("Select Cursor");
        cursorImage.SetActive(true);
        cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        //selected object should be whatever the player has focused.
    }



    public virtual void Interact()
    {
    }
    void Update()
    {
        //used to test the status of isFocus
        if (isFocus)
        {
            print(player.GetComponent<PlayerInteraction>().focus.name);
        }
        //used for tracking object's position
        selectedObject = GetComponent<Renderer>();

        initInteract();
        //placeCursor();
    }

    //checks if we're close enough to interact & if we've already interacted
    public void initInteract()
    {
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.transform.position, transform.position);
            if (distance <= radius)
            {
                Interact();
            }
        }
        hasInteracted = true;
    }

    //turns on isFocus and is used in the PlayerInteraction Script
    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        print("isFocus : " + isFocus);
        player = playerTransform;
        hasInteracted = false;

    }

    //turns off isFocus and is used in the PlayerInteraction Script
    public void OnDefocused()
    {
        isFocus = false;
        print("isFocus : " + isFocus);
        player = null;
        hasInteracted = false;
    }
}

