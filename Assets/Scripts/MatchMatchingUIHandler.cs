using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchMatchingUIHandler : MonoBehaviour
{
    [SerializeField] List<Utility.PlayerProfile> playerProfileList;
    private RectTransform rectTransform;
    [SerializeField] MainMenuManager mainMenuManager;

    public void Init(RectTransform parent,MainMenuManager menuManager)
    {
        rectTransform = this.GetComponent<RectTransform>();
        rectTransform.SetParent(parent);
        rectTransform.SetAsFirstSibling();
        mainMenuManager = menuManager;

    }
}
