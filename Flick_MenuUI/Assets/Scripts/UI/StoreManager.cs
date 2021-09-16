using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
    
{
    [SerializeField] GameObject purchaseFailed;
    [SerializeField] GameObject purchasedPotion;
    [SerializeField] GameObject purchasedMushroom;
    [SerializeField] GameObject purchasePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyPotionButton()
    {
        purchasePanel.SetActive(true);

        int coins = PlayerPrefs.GetInt("score");
        int jewels = PlayerPrefs.GetInt("jewel");

        if(jewels>=5 && coins>=500)
        {
            PlayerPrefs.SetInt("jewel", PlayerPrefs.GetInt("jewel") - 5);
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 500);
            purchasedPotion.SetActive(true);
        }
        else
        {
            purchaseFailed.SetActive(true);
        }
    }

    public void BuyMushroomButton()
    {
        purchasePanel.SetActive(true);

        int coins = PlayerPrefs.GetInt("score");
        int jewels = PlayerPrefs.GetInt("jewel");

        if (jewels >= 10 && coins >= 1000)
        {
            PlayerPrefs.SetInt("jewel", PlayerPrefs.GetInt("jewel") - 5);
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 500);
            purchasedMushroom.SetActive(true);
        }
        else
        {
            purchaseFailed.SetActive(true);
        }
    }

    public void OkPurchaseFailed()
    {
        purchaseFailed.SetActive(false);
        purchasePanel.SetActive(false);
    }
    public void OkPurchasedPotion()
    {
        purchasedPotion.SetActive(false);
        purchasePanel.SetActive(false);
    }
    public void OkPurchasedMushroom()
    {
        purchasedMushroom.SetActive(false);
        purchasePanel.SetActive(false);
    }
}
