using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class WeaponPart : MonoBehaviour
{
    [Header("Toggles")]
    public bool hasChildren;
    public bool hasCustomColor;

    [Header("General settings")]
    public Sprite partSprite;
    public EPartName partName;

    [Header("Stats")]
    public WepaonStat statProviderGood;
    public WepaonStat statProviderBad;

    // if has chilldren
    [Header("Child options")]
    public Transform childPlace;

    // if has custom colors
    [Header("Custom color options")]
    public List<Sprite> customColoredSprites;
    public Color customColor;
}
[CustomEditor(typeof(WeaponPart))]
public class WeaponPartEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var weaponPart = target as WeaponPart;

        EditorGUILayout.PropertyField(serializedObject.FindProperty("hasChildren"), true);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("hasCustomColor"), true);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("partSprite"), true);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("partName"), true);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("statProviderGood"), true);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("statProviderBad"), true);

        if (weaponPart.hasChildren)
            EditorGUILayout.PropertyField(serializedObject.FindProperty("childPlace"), true);

        if(weaponPart.hasCustomColor)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("customColoredSprites"), true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("customColor"), true);
        }

        serializedObject.ApplyModifiedProperties();
    }
}
[System.Serializable]
public class WepaonStat
{
    public int statValue;
    public EWeaponStatType statType;
}