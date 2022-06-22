using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCreator : MonoBehaviour
{
    #region singleton
    public static WeaponCreator Instance { get; private set; }
    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    #endregion
    [SerializeField] private List<WeaponPart> gunParts;
    [SerializeField] private List<WeaponPart> bowParts;
    [SerializeField] private List<WeaponPart> rodParts;

    public GameObject CreateGun()
    {
        GameObject gunObject = new GameObject();

        var mainList = gunParts.FindAll(g => g.partName == EPartName.G_main);

        var stocksList = gunParts.FindAll(g => g.partName == EPartName.G_stock);

        var sightsList = gunParts.FindAll(g => g.partName == EPartName.G_sight);

        var silencersList = gunParts.FindAll(g => g.partName == EPartName.G_silencer);

        return gunObject;
    }
    public GameObject CreateBow()
    {
        GameObject bowObject = new GameObject();

        var mainList = bowParts.FindAll(b => b.partName == EPartName.B_main);

        var arrowHeadsList = bowParts.FindAll(b => b.partName == EPartName.B_arrowHead);

        var arrowFletchingsList = bowParts.FindAll(b => b.partName == EPartName.B_arrowFletching);

        return bowObject;
    }
    public GameObject CreateRod()
    {
        GameObject rodObject = new GameObject();

        var mainList = rodParts.FindAll(r => r.partName == EPartName.R_main);

        var crystalsList = rodParts.FindAll(r => r.partName == EPartName.R_crystal);

        return rodObject;
    }
}
