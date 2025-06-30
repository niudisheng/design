using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button ReturnButton;

    private void Awake()
    {
        ReturnButton.onClick.AddListener(ReturnToMainMenu);
    }

    private void ReturnToMainMenu()
    {
        GameManager.LoadMenu();
    }
    
}
