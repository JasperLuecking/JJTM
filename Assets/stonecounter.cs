using UnityEngine;
using UnityEngine.UI;

public class stonecounter : MonoBehaviour
{
    public Text Stonecounter;

    void Update()
    {
        Stonecounter.text = $"Stone: {Inventory.stone}";
    }
}
