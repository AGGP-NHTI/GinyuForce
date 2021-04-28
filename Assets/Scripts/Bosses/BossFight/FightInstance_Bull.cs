using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightInstance_Bull : FightInstance
{
    public GameObject bullEntrancePoint;

    private BullPawn Bull;

    public float entranceWaitTime = 1.2f;

    private void Awake()
    {
        if(InstanceBoss is BullPawn)
        {
            Bull = (BullPawn)InstanceBoss;
        }

        StartCoroutine(DramaticEntrance(entranceWaitTime));
    }

    protected IEnumerator DramaticEntrance(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        Bull.BossAttack3(bullEntrancePoint.transform.position);
    }
}
