using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneController : ZoneType
{
    double timePassed;

    public void OnStrengthZoneEnter()
    {
        UpdateAttackDamageGUI(2, .5f);
    }

    public void OnDamageZoneEnter()
    {
        UpdateHealthGUI(-1, 0.5f);
    }
    public void OnManaZoneEnter()
    {
        UpdateManaGUI(5, 1f);
    }
    public void OnHealthZoneEnter()
    {
        UpdateHealthGUI(1, 0.5f);
    }


    public void UpdateHealthGUI(float HealAmount, float DelayTime)
    {
        app.model.HealthBar.maxValue = 100;
        timePassed += Time.deltaTime;
        if (timePassed >= DelayTime)
        {
            app.model.HealthPoints += HealAmount;
            app.model.HealthBar.value = app.model.HealthPoints;
            timePassed = 0;
            app.model.HealthAmountText.text = app.model.HealthPoints.ToString() + "/100";
        }
    }
    public void UpdateManaGUI(float manaAmount, float DelayTime)
    {
        app.model.ManaBar.maxValue = 100;
        timePassed += Time.deltaTime;
        if (timePassed >= DelayTime)
        {
            app.model.ManaAmount += manaAmount;
            app.model.ManaBar.value = app.model.ManaAmount;
            timePassed = 0;
            app.model.ManaAmountText.text = app.model.ManaAmount.ToString() + "/100";
        }
    }

    public void UpdateAttackDamageGUI(float strengthAmount, float DelayTime)
    {
        app.model.AttackDamageAmountText.text = app.model.StrengthPoints.ToString();
        timePassed += Time.deltaTime;
        if (timePassed >= DelayTime)
        {
            app.model.StrengthPoints += strengthAmount;
            timePassed = 0;
            app.model.AttackDamageAmountText.text = app.model.StrengthPoints.ToString();
        }
    }
}
