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

    protected AudioSource fightTheme = null;

    protected virtual void Awake()
    {
        if (InstanceBoss == null)
        {
            InstanceBoss = FindObjectOfType<BossPawn>();
        }

        if(fightTheme == null)
        {
            fightTheme = gameObject.GetComponent<AudioSource>();
        }

        Time.timeScale = 1f;
    }

    public virtual void StartBossTheme()
    {
        fightTheme.Play();
    }

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
