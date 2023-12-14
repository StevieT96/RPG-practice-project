using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnitStats : MonoBehaviour
{
    [Header("Stats")]
    public float HP;
    public float MP;
    public float ATK;
    public float DEF;
    public float SPD;
    public float EXP;

    private float startHP;
    private float startMP;

    [HideInInspector]
    public int NextTurn;
}
