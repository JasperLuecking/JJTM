using UnityEngine;
using UnityEngine.UI;

public class goldcounter : MonoBehaviour
{
    public Text Goldcounter;

    void Update()
    {
        Goldcounter.text = $"Gold: {Inventory.gold}";
    }
}
