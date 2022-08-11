using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject pvpPanel;
    public GameObject matchMakingPanel;

    public Button pvpButton;

    public void Connect()
    {
        pvpPanel.SetActive(false);
        matchMakingPanel.SetActive(true);  
    }



}
