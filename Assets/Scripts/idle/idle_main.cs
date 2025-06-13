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
    private float xp;
    private TMP_Text lvl;
    private int temp_lvl;
    private bool lvl_up = false;

    public void button_click()
    {
        skill = this.transform.parent.gameObject.name;
        //Debug.Log(this.transform.parent.gameObject.name);

        Debug.Log(this.transform.parent.gameObject);
        switch (skill)
        {
            case "Fishing":
                Debug.Log("We fishing now bois 😎");
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

    IEnumerator interval_progress_bar()
    {
        // evt sende hvilket skill det er som parameter utifra hva som ble klikket på
        while (true)
        {
            float interval_timer = 3f; // hent info fra skills om hvilket verktøy/ tool som brukes og gjør den proporsjonal med progress interval baren i toppen
            xp_bar.value += 1000;
            Debug.Log(xp_bar.value);
            yield return new WaitForSecondsRealtime(interval_timer); // bruk variabel istedenfor konstant 3 utifra verktøy spilleren bruker.
            lvl_up = true;
            lvl_up_skill();
        }
    }

    public void lvl_up_skill()
    {
        if (lvl_up)
        {
            temp_lvl = int.Parse(lvl.text);
            temp_lvl++;
            lvl.text = temp_lvl.ToString();
        }
    }

    // ---- XP-system ----

    /* ---- Hva jeg trenger:
     * hente hvilket lvl skill er, for å vite hvor mye xp som trengs for å lvl
     * hente hvilket tool spilleren har equipped, for å vite hvor lang tid intervallet tar mellom hver action
     */
}
