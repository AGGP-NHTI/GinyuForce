using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthbar : Core
{
    [SerializeField]
    private GameObject[] _emptyHeartContainers;

    [SerializeField]
    private GameObject[] _fullHeartContainers;

    private int _numOfHearts = 0;

    private void Start()
    {
        for(int i = 0; i < GameInstanceManager.Main.ThePlayer.CurrentHealth; i++)
        {
            _fullHeartContainers[i] = Instantiate(PlayerUIManager.Main.PlayerHeartSprite, _emptyHeartContainers[i].transform);

            _numOfHearts++;
        }

        _fullHeartContainers[_numOfHearts - 1].GetComponent<Animator>().Play("Heartbeat");
    }

    /// <summary>
    /// Currently does not have a method for healing the player. Will add that if such a functionality is added to the game.
    /// </summary>
    public void UpdateHearts()
    {
        for(int i = _numOfHearts; i > (int)GameInstanceManager.Main.ThePlayer.CurrentHealth; i--)
        {
            Destroy(_fullHeartContainers[i - 1]);
            _numOfHearts--;
        }

        if(_numOfHearts > 0)
        {
            _fullHeartContainers[_numOfHearts - 1].GetComponent<Animator>().Play("Heartbeat");
        }
    }
}
