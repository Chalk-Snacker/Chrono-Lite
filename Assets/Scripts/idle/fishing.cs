using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fishing : MonoBehaviour
{
    private float xp_bar;

    //private int n = 1; // number of seconds between the ticks
    /*public void SubmitSliderSetting(){
      Debug.Log(xp_bar.value);
    }
    */
    //float interval = n * 1000;
    // Start is called before the first frame update

    void Start()
    {
        xp_bar = GameObject.Find("XP bar fishing").GetComponent<Slider>().value;
    }

    // void Test_timer(){}

    //Update is called once per frame
    void Update()
    {
        xp_bar += 1;
        //Debug.Log(xp_bar);
    }
}

// her skal bare kunne endre xpbar progress og oppdatere lvl. selve progressbar er et eget script.
// husk å endre tot xp for new lvl etter å ha levlet up

/*
 * --- Små bugs/ fixes ---
 *  når du trykker på fishing, instantly får du xå, skal kun skje etter baren i toppen er fullført
 *  Idle ting kjører ikke hvis du tabber ut fra unity, MÅ kjøre selv i bakgrunnen..
 *
 */
