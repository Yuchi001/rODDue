using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "My Assets/WeaponStatsBase")]
public class WeaponStatsBase : ScriptableObject
{
    [Header("Bow")]
    public List<StatCalc> bowStats;


    [Header("Gun")]
    public List<StatCalc> gunStats;


    [Header("Rod")]
    public List<StatCalc> rodStats;

}
[System.Serializable]
public class StatCalc
{
    public string name;
    public int statValue;
    public WeaponPart weaponPart;
}