using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject SettingsMenu;
    [SerializeField] GameObject DailyRewardsMenu;
    [SerializeField] GameObject ChallengesMenu;
    [SerializeField] GameObject StoreMenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
