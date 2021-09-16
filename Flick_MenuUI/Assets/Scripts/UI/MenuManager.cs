using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject SettingsMenu;
    [SerializeField] GameObject DailyRewardsMenu;
    [SerializeField] GameObject ChallengesMenu;
    [SerializeField] GameObject StoreMenu;

    [SerializeField] Text Coins;
    [SerializeField] Text Jewel;
    void Start()
    {
        Coins.text = PlayerPrefs.GetInt("score").ToString();
        Jewel.text = PlayerPrefs.GetInt("jewel").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Coins.text = PlayerPrefs.GetInt("score").ToString();
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void CloseButton()
    {
        SettingsMenu.SetActive(false);
        DailyRewardsMenu.SetActive(false);
        ChallengesMenu.SetActive(false);
        StoreMenu.SetActive(false);
    }

    public void SettingsButton()
    {
        SettingsMenu.SetActive(true);
    }
    public void DailyRewardsButton()
    {
        DailyRewardsMenu.SetActive(true);
    }

    public void ChallengesButton()
    {
        ChallengesMenu.SetActive(true);
    }
    public void StoreButton()
    {
        StoreMenu.SetActive(true);
    }

}
