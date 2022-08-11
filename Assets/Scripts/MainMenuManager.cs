using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class MainMenuManager : MonoBehaviour
{
    [SerializeField] Button submitButton;
    [SerializeField] InputField playerNameInputField;
    [SerializeField] GameObject playerNamePanel;
    [SerializeField] GameObject pvpPanel;
    [SerializeField] GameObject matchMakingPanel;
    public const string playerName = "ndbhjgfyu";

    private void Awake()
    {
        submitButton.onClick.AddListener(OnNameSubmit);
    }

    private void OnNameSubmit()
    {
        playerNamePanel.SetActive(false);
        PlayerPrefs.SetString(playerName, playerNameInputField.text);
        pvpPanel.SetActive(true);
    }

    private void ClickPvpButton()
    {
        pvpPanel.SetActive(false);
        matchMakingPanel.SetActive(true);
        Connect();
    }

    private void Connect()
    {
        //todo
    }
}
