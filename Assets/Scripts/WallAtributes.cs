using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAtributes
{
    public float SpawnTime { get; set; }
    public float Speed { get; set; }
    public float RotateSpeed { get; set; }
    public bool SpawnLeft { get; set; }
    public bool SpawnRight { get; set; }
    public int LocationSpawn { get; set; }
    public float Thickness { get; set; }


    public WallAtributes(float spawnTime, float speed, float rotateSpeed, bool spawnLeft, bool spawnRight, int locationSpawn, float thickness)
    {
        SpawnTime = spawnTime;
        Speed = speed;
        RotateSpeed = rotateSpeed;
        SpawnLeft = spawnLeft;
        SpawnRight = spawnRight;
        LocationSpawn = locationSpawn;
        Thickness = thickness;
    }

}
