using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;
    public int MaxHealth = 200;
    public int currentHealth;
    public int MaxSP = 100;
    public int currentSP;


    public HealthBar healthBar;
    public SkillBar skillBar;

    void Start()
    {
        currentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
        currentSP = MaxSP;
        skillBar.SetMaxSP(MaxSP);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            UseSkillPoints(10);
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
    void UseSkillPoints(int UseSP)
    {
        currentSP -= UseSP;
        skillBar.SetSP(currentSP);
    }
}
