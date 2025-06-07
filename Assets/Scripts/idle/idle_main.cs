using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ---- denne classen er for progress bar/ interval baren for skills ----
public class Idle_main : MonoBehaviour, Ibutton_click
{
    private Slider xp_bar;
    private string skill;

    public void button_click()
    {
        skill = this.transform.parent.gameObject.name;
        //Debug.Log(this.transform.parent.gameObject.name);

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
        }
    }
}
