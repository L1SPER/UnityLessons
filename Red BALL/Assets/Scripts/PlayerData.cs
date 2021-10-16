using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public int health;
    public float ballPosx;
    public float ballPosy;
    public float ballPosz;

    public float blockPosx;
    public float blockPosy;
    public float blockPosz;


    public PlayerData(HeartSystem player)
    {
        health = player.health;
        ballPosx = player.ballPos.x;
        ballPosy = player.ballPos.y;
        ballPosz = player.ballPos.z;

        blockPosx = player.blockPos.x;
        blockPosy = player.blockPos.y;
        blockPosz = player.blockPos.z;


    }
}
