using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objectives : MonoBehaviour
{
    private IDictionary<string, bool> objectiveList = new Dictionary<string, bool>();
    //PlayerPrefs[] objComplete;
    PlayerMovement playermvmt;
    [SerializeField] Text[] textsOnDisplay = new Text[5];
    string[] objectiveString = new string[5];
    
    void Start()
    {
        objectiveList.Add("Collect 20 coins in a single run",false);
        objectiveList.Add("Collect 50 coins in a single run", false);
        objectiveList.Add("Run 150m", false);
        objectiveList.Add("Run 100m", false);
        objectiveList.Add("Collect 5 jewels", false);
        //objComplete = new PlayerPrefs[objectiveList.Count];

        objectiveString[0] = "Collect 20 coins in a single run";
        objectiveString[1] = "Collect 50 coins in a single run";
        objectiveString[2] = "Run 150m";
        objectiveString[3] = "Run 100m";
        objectiveString[4] = "Collect 5 jewels";
    }

    
    void Update()
    {
        UpdateDictionary();
        UpdateOnDisplay();
    }

    void UpdateDictionary()
    {
        if (PlayerPrefs.GetInt("scorePlayerPrefs") >= 20)
            objectiveList["Collect 20 coins in a single run"] = true;

        if (PlayerPrefs.GetInt("scorePlayerPrefs",0) >= 50)
            objectiveList["Collect 50 coins in a single run"] = true;

        if (PlayerPrefs.GetInt("distancePlayerPrefs",0) >= 150)
            objectiveList["Run 150m"] = true;

        if (PlayerPrefs.GetInt("distancePlayerPrefs",0) >= 100)
            objectiveList["Run 100m"] = true;
        //Debug.Log(objectiveList[objectiveString[3]]);

        if (PlayerPrefs.GetInt("jewelPlayerPrefs",0) >= 5)
            objectiveList["Collect 5 jewels"] = true;
    }

    void UpdateOnDisplay()
    {
       /* textsOnDisplay[0].text = "Collect 20 coins in a single run";
        textsOnDisplay[1].text = "Collect 50 coins in a single run";
        textsOnDisplay[2].text = "Run 150m";
        textsOnDisplay[3].text = "Run 100m";
        textsOnDisplay[4].text = "Collect 5 jewels";*/

        //setting strings to display on screen 
        for(int i=0;i<5;i++)
        {
            string currentObjectiveString = objectiveString[i];
            textsOnDisplay[i].text = currentObjectiveString;
        }

        //displaying only active objectives
        for(int i=0;i<5;i++)
        {
            string currentObjectiveString = objectiveString[i];
            if(objectiveList[currentObjectiveString])
            {
                textsOnDisplay[i].gameObject.SetActive(false);
            }
        }
    }
}
