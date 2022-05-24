using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public GameObject leftDownPanel;
    public GameObject Computer;
    public GameObject onComputerSuspPanel;
    void Update()
    {
        if (Computer.activeSelf)
        {
            GameController.onPause = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
        if (Input.GetKeyDown(KeyCode.Escape) && !Computer.activeSelf)
        {
            GameController.onPause = !GameController.onPause;
        }
        if (!GameController.onPause && Input.GetKeyDown(KeyCode.Tab))
        {
            leftDownPanel.SetActive(!leftDownPanel.activeSelf);
        }
    }
    public void OnComputerSuspButton()
    {
        if (onComputerSuspPanel.activeSelf)
        {
            onComputerSuspPanel.SetActive(false);
        }
        else
        {
            onComputerSuspPanel.SetActive(true);
        }
    }
    public void OnComputerQuitButton()
    {
        Computer.SetActive(false);
        GameController.onPause = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
