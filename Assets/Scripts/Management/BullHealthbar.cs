using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Made using help from https://www.youtube.com/watch?v=BLfNP4Sc_iA

public class BullHealthbar : Core
{
    public Slider healthSlider;

    public TextMeshProUGUI percentText;

    private void Update()
    {
        float healthPercent = (GameInstanceManager.Main.CurrentBoss.CurrentHealth / GameInstanceManager.Main.CurrentBoss.GetActorMaxHealth()) * 100f;

        if(healthPercent >= 0f)
        {
            healthSlider.value = healthPercent;

            percentText.SetText((int)healthPercent + "%");
        }
        else
        {
            healthSlider.value = 0f;

            percentText.SetText("0%");
        }
    }
}
