using UnityEngine;
using UnityEngine.UI;

public class woodcounter : MonoBehaviour
{
    public Text Woodcounter;

    void Update()
    {
        Woodcounter.text = $"Wood: {Inventory.wood}";
    }
}
