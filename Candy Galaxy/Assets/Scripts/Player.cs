using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Image starImage;
    public Sprite iconStar;
    public Sprite iconNoStar;
    private bool carryingStar = false;
    public Text candyText;
    private int totalCandy = 0;
    private PlayerInventoryDisplay playerInventoryDisplay;
    private int totalLolly = 0;
    void Start()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
        UpdateCandyText();

    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Star"))
        {
            carryingStar = true;
            UpdateStarImage();
            Destroy(hit.gameObject);
        }
        if (hit.CompareTag("Candy"))
        {
            totalCandy++;
            UpdateCandyText();
            Destroy(hit.gameObject);
        }
        if (hit.CompareTag("Lolly"))
        {
            totalLolly++;
            playerInventoryDisplay.OnChangeLollyTotal(totalLolly);
            Destroy(hit.gameObject);
        }


    }
    private void UpdateCandyText()
    {
        string candyMessage = "candy = " + totalCandy;
        candyText.text = candyMessage;
    }

    private void UpdateStarImage()
    {
        if (carryingStar)
            starImage.sprite = iconStar;
        else
            starImage.sprite = iconNoStar;
    }
}
