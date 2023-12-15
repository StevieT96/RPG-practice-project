using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public enum BattleState { Begin, PlayerTurn, EnemyTurn, Victory, Defeat}
}
public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform EnemyArea;
    

    public BattleState state;

    void Start()
    {
        state = BattleState.Begin;
        SetupBattle();
       
    }
    void SetupBattle()
    {
       // Instantiate(playerPrefab,); //
        Instantiate(enemyPrefab, EnemyArea);
    }
}
