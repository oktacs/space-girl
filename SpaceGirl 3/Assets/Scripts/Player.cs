using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Image starImage;
    public Sprite iconStar;
    public Sprite iconNoStar;
    private bool carryingStar = false;
    public Text starText;
    private int totalStars = 0;
    private PlayerInventoryDisplay playerInventoryDisplay;
    private int totalLolly = 0;

    void Start()
    {
        UpdateStarText();
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
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
            totalStars++;
            UpdateStarText();
            Destroy(hit.gameObject);
        }
        if (hit.CompareTag("Lolly"))
        {
            totalLolly++;
            playerInventoryDisplay.OnChangeStarTotal(totalLolly);
            Destroy(hit.gameObject);
        }

    }
    private void UpdateStarImage()
    {
        if (carryingStar)
            starImage.sprite = iconStar;
        else
            starImage.sprite = iconNoStar;
    }
    private void UpdateStarText()
    {
        string starMessage = "candy = " + totalStars;
        starText.text = starMessage;
    }
}
