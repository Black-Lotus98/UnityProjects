using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ZoneModel : ZoneType
{
    public float HealthPoints = 100;
    public float ManaAmount;
    public float StrengthPoints;
    public TextMeshProUGUI AttackDamageAmountText;
    public TextMeshProUGUI HealthAmountText;
    public TextMeshProUGUI ManaAmountText;

    public Slider HealthBar;
    public Slider ManaBar;

}
