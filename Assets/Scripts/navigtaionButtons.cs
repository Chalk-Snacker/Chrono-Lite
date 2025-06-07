using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation_button : MonoBehaviour, Ibutton_click
{
    private string button_clicked;

    public void button_click()
    {
        button_clicked = this.transform.gameObject.name;

        switch (button_clicked)
        {
            case "Idle_button":
                Debug.Log("Idle loaded?");
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName: "Idle");
                break;
            case "Attack_button":
                Debug.Log("Attack loaded?");
                //UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName: "Idle");
                break;
            case "Inventory_button":
                Debug.Log("Inventory loaded?");
                //UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName: "Idle");
                break;
            case "Shop_button":
                Debug.Log("Shop loaded?");
                //UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName: "Idle");
                break;
            case "Settings_button":
                Debug.Log("Settings loaded?");
                //UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName: "Idle");
                break;
        }
    }
}
