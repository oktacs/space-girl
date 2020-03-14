using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] lollyPlaceholders;
    public Sprite iconLolly;
    public Sprite iconLollyGrey;
    public void OnChangeLollyTotal(int lollyTotal)
    {
        for (int i = 0; i < lollyPlaceholders.Length; ++i)
        {
            if (i < lollyTotal)
                lollyPlaceholders[i].sprite = iconLolly;
            else
                lollyPlaceholders[i].sprite = iconLollyGrey;
        }
    }
}
