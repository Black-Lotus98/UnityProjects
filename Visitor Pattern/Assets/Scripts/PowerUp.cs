using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerUp", menuName = "PowerUp")]
public class PowerUp : ScriptableObject, IVisitor
{
    public string powerUpName;
    public GameObject powerUpPrefab;
    public string powerUpDescription;

    [Tooltip("Fully heal Shield")]
    public bool healShield = false;

    [Range(0.0f, 50f)]
    [Tooltip("Boost engine settings by turbo")]
    public float turboBoost;

    [Range(0.0f, 25f)]
    [Tooltip("Boost weapon range settings")]
    public int weaponRange;

    [Range(0.0f, 50f)]

    [Tooltip("Boost weapon strength settings")]
    public float weaponStrength;

    public void Visit(BikeShield aBikeShield)
    {
        if (healShield == true)
        {
            aBikeShield.Heal(100.0f);
        }
    }
    public void Visit(BikeEngin aBikeEngin)
    {
        float boost = aBikeEngin.turboBoost += turboBoost;

        if (boost < 0.0f)
        {
            aBikeEngin.turboBoost = 0.0f;
        }

        // check if turbo boost is greater than the max turbo boost and set it to the max turbo boost, so it doesn't go over the max turbo boost
        if (boost > aBikeEngin.maxTurboBoost)
        {
            aBikeEngin.turboBoost = aBikeEngin.maxTurboBoost;
        }
    }
    public void Visit(BikeWeapon aBikeWeapon)
    {
        int range = aBikeWeapon.range + weaponRange;

        // Check if range is greater than the max range and set it to the max range, so it doesn't go over the max range
        if (range >= aBikeWeapon.maxRange)
        {
            aBikeWeapon.range = aBikeWeapon.maxRange;
        }
        else
        {
            aBikeWeapon.range += range;
        }

        float strength = aBikeWeapon.strength += Mathf.Round(aBikeWeapon.strength * weaponStrength / 100);
        if (strength >= aBikeWeapon.maxStrength)
        {
            aBikeWeapon.strength = aBikeWeapon.maxStrength;
        }
        else
        {
            aBikeWeapon.strength += strength;
        }
    }
}
