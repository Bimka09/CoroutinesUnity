using System;
using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Character Player;
    public Character Enemy;

    private void Start()
    {
        StartCoroutine(LevelLoop());
    }

    private IEnumerator LevelLoop()
    {
        while(true)
        {
            if(Player.Health > 0 && Enemy.Health > 0)
            {
                yield return Player.Attack(Enemy);
            }
            if(Player.Health > 0 && Enemy.Health > 0)
            {
                yield return Enemy.Attack(Player);
            }
            if(Player.Health <= 0 || Enemy.Health <= 0)
            {
                yield break;
            }
        }
    }
}
