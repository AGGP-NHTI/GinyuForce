using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightInstance : Core
{
    public delegate void BossDownEvent();

    public static BossDownEvent OnBossDown;

    public BossPawn InstanceBoss;

    public PlayerPawn Player;

    public bool fightIsActive = true;

    public float fightTime = 0f;

    public int playerScore = 1000;

    protected virtual void Update()
    {
        if(fightIsActive)
        {
            fightTime += Time.deltaTime;

            if (InstanceBoss.CurrentHealth <= 0)
            {
                fightIsActive = false;

                LogMsg("The boss has been defeated!");

                OnBossDown?.Invoke();
            }
        }
    }
}
