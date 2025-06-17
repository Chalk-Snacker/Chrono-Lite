using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// ---- denne classen er for progress bar/ interval baren for skills ----
public class Idle_main : MonoBehaviour, Ibutton_click
{
    private string skill;
    private Slider xp_bar;

    private int xp;
    private int remaining_xp;
    private TMP_Text lvl;
    private int current_lvl;

    //private bool lvl_up = false;
    private int xp_threshold;

    public void button_click()
    {
        skill = this.transform.parent.gameObject.name;

        switch (skill)
        {
            case "Fishing":
                //Debug.Log("We fishing now bois 😎");
                break;
            case "Cooking":
                Debug.Log("Cooking in progress 🍲");
                break;
            case "Alchemy":
                Debug.Log("Brewing up some potions 🧪");
                break;
            case "Woodcutting":
                Debug.Log("Chopping some wood 🪓");
                break;
            case "Mining":
                Debug.Log("Mining some ore ⛏");
                break;
            case "Manipulation":
                Debug.Log("Being a dickhead 👹");
                break;
        }

        xp_bar = GameObject.Find("XP-bar_" + skill).GetComponent<Slider>();
        lvl = GameObject.Find("Lvl_" + skill).GetComponent<TMP_Text>();

        StartCoroutine(interval_progress_bar());
    }

    public void update_xp_threshold()
    {
        current_lvl = int.Parse(lvl.text);
        xp_threshold = 27 * current_lvl;
        xp_bar.maxValue = xp_threshold;
    }

    IEnumerator interval_progress_bar()
    {
        while (true)
        {
            float interval_timer = 3f; // hent info fra skills om hvilket verktøy/ tool som brukes og gjør den proporsjonal med progress interval baren i toppen

            update_xp_threshold(); // temp threhold
            xp = (int)Math.Round(xp_bar.value + Pond.Backyard.XP);
            if (xp >= xp_threshold)
            {
                remaining_xp = (int)Math.Round(xp_threshold % xp_bar.value);
                Debug.Log("remaining xp: " + remaining_xp);
                current_lvl++;
                lvl.text = current_lvl.ToString();
                update_xp_threshold();
                xp_bar.value = remaining_xp;
            }
            else
            {
                xp_bar.value += Pond.Backyard.XP; // select current pond, not hard coding it
            }
            yield return new WaitForSecondsRealtime(interval_timer);
        }
    }
}
