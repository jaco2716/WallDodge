using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Random = UnityEngine.Random;

public class WallSpawner : MonoBehaviour
{
    public float timeSinceLastSpawn;
    public List<WallAtributes> wallAtributes;
    private int listItem = 0;
    public GameObject wall;
    private float xCordStraight = 3.3f;
    private float yCordStraight = 6;
    private float xCordSkew = 3.4f;
    private float yCordSkew = 8;
    private float wallLength = 6;

    // Start is called before the first frame update
    void Start()
    {

        wallAtributes = new List<WallAtributes>()
        {
            new WallAtributes(1, 2, 0, true, true, 1, 0.3f),
            new WallAtributes(3, 2, 0, true, true, 2, 0.3f),
            new WallAtributes(5, 2, 0, true, true, 3, 0.3f),
            new WallAtributes(7, 2, 0, true, true, 4, 0.3f),
            new WallAtributes(9, 2, 0, true, true, 5, 0.3f),
            new WallAtributes(11, 2, 0, true, true, 6, 0.3f),
            new WallAtributes(13, 2, 0, true, true, 7, 0.3f),
            new WallAtributes(15, 2, 0, true, true, 8, 0.3f)
        };
    }

    // Update is called once per frame
    void Update()
    {
        
        timeSinceLastSpawn += Time.deltaTime;
        if (listItem <= wallAtributes.Count - 1)
        {
            if (timeSinceLastSpawn >= wallAtributes[listItem].SpawnTime)
            {
                if (wallAtributes[listItem].LocationSpawn == 1) SpawnWallTop();
                
                if (wallAtributes[listItem].LocationSpawn == 2) SpawnWallRight();
                
                if (wallAtributes[listItem].LocationSpawn == 3) SpawnWallBottom();
                
                if (wallAtributes[listItem].LocationSpawn == 4) SpawnWallLeft();

                if (wallAtributes[listItem].LocationSpawn == 5) SpawnWallTopRight();

                if (wallAtributes[listItem].LocationSpawn == 6) SpawnWallBottomRight();

                if (wallAtributes[listItem].LocationSpawn == 7) SpawnWallBottomLeft();

                if (wallAtributes[listItem].LocationSpawn == 8) SpawnWallTopLeft();


                listItem++;
            }
        }
    }

    
    private void SpawnWallTop()
    {
        if (wallAtributes[listItem].SpawnLeft)
        {
            GameObject wall1 = Instantiate(wall, new Vector3(-xCordStraight, yCordStraight), Quaternion.AngleAxis(90, Vector3.forward));
            wall1.GetComponent<Rigidbody2D>().velocity = Vector2.down * wallAtributes[listItem].Speed;
            wall1.GetComponent<Rigidbody2D>().angularVelocity = wallAtributes[listItem].RotateSpeed;
            wall1.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }

        if (wallAtributes[listItem].SpawnRight)
        {
            GameObject wall2 = Instantiate(wall, new Vector3(xCordStraight, yCordStraight), Quaternion.AngleAxis(90, Vector3.forward));
            wall2.GetComponent<Rigidbody2D>().velocity = Vector2.down * wallAtributes[listItem].Speed;
            wall2.GetComponent<Rigidbody2D>().angularVelocity = -wallAtributes[listItem].RotateSpeed;
            wall2.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }
    }

    private void SpawnWallRight()
    {
        if (wallAtributes[listItem].SpawnLeft)
        {
            GameObject wall1 = Instantiate(wall, new Vector3(yCordStraight, xCordStraight), Quaternion.identity);
            wall1.GetComponent<Rigidbody2D>().velocity = Vector2.left * wallAtributes[listItem].Speed;
            wall1.GetComponent<Rigidbody2D>().angularVelocity = wallAtributes[listItem].RotateSpeed;
            wall1.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }

        if (wallAtributes[listItem].SpawnRight)
        {
            GameObject wall2 = Instantiate(wall, new Vector3(yCordStraight, -xCordStraight), Quaternion.identity);
            wall2.GetComponent<Rigidbody2D>().velocity = Vector2.left * wallAtributes[listItem].Speed;
            wall2.GetComponent<Rigidbody2D>().angularVelocity = -wallAtributes[listItem].RotateSpeed;
            wall2.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }
    }

    private void SpawnWallBottom()
    {
        if (wallAtributes[listItem].SpawnLeft)
        {
            GameObject wall1 = Instantiate(wall, new Vector3(-xCordStraight, -yCordStraight), Quaternion.AngleAxis(90, Vector3.forward));
            wall1.GetComponent<Rigidbody2D>().velocity = Vector2.up * wallAtributes[listItem].Speed;
            wall1.GetComponent<Rigidbody2D>().angularVelocity = wallAtributes[listItem].RotateSpeed;
            wall1.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }

        if (wallAtributes[listItem].SpawnRight)
        {
            GameObject wall2 = Instantiate(wall, new Vector3(xCordStraight, -yCordStraight), Quaternion.AngleAxis(90, Vector3.forward));
            wall2.GetComponent<Rigidbody2D>().velocity = Vector2.up * wallAtributes[listItem].Speed;
            wall2.GetComponent<Rigidbody2D>().angularVelocity = -wallAtributes[listItem].RotateSpeed;
            wall2.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }
    }

    private void SpawnWallLeft()
    {
        if (wallAtributes[listItem].SpawnLeft)
        {
            GameObject wall1 = Instantiate(wall, new Vector3(-yCordStraight, xCordStraight), Quaternion.identity);
            wall1.GetComponent<Rigidbody2D>().velocity = Vector2.right * wallAtributes[listItem].Speed;
            wall1.GetComponent<Rigidbody2D>().angularVelocity = wallAtributes[listItem].RotateSpeed;
            wall1.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }

        if (wallAtributes[listItem].SpawnRight)
        {
            GameObject wall2 = Instantiate(wall, new Vector3(-yCordStraight, -xCordStraight), Quaternion.identity);
            wall2.GetComponent<Rigidbody2D>().velocity = Vector2.right * wallAtributes[listItem].Speed;
            wall2.GetComponent<Rigidbody2D>().angularVelocity = -wallAtributes[listItem].RotateSpeed;
            wall2.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }
    }

    private void SpawnWallTopRight()
    {
        if (wallAtributes[listItem].SpawnLeft)
        {
            GameObject wall1 = Instantiate(wall, new Vector3(xCordSkew, yCordSkew), Quaternion.AngleAxis(45, Vector3.forward));
            wall1.GetComponent<Rigidbody2D>().velocity = new Vector2(-1, -1) * wallAtributes[listItem].Speed;
            wall1.GetComponent<Rigidbody2D>().angularVelocity = wallAtributes[listItem].RotateSpeed;
            wall1.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }

        if (wallAtributes[listItem].SpawnRight)
        {
            GameObject wall2 = Instantiate(wall, new Vector3(yCordSkew, xCordSkew), Quaternion.AngleAxis(45, Vector3.forward));
            wall2.GetComponent<Rigidbody2D>().velocity = new Vector2(-1,-1) * wallAtributes[listItem].Speed;
            wall2.GetComponent<Rigidbody2D>().angularVelocity = -wallAtributes[listItem].RotateSpeed;
            wall2.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }
    }

    private void SpawnWallBottomRight()
    {
        if (wallAtributes[listItem].SpawnLeft)
        {
            GameObject wall1 = Instantiate(wall, new Vector3(xCordSkew, -yCordSkew), Quaternion.AngleAxis(-45, Vector3.forward));
            wall1.GetComponent<Rigidbody2D>().velocity = (Vector2.up + Vector2.left) * wallAtributes[listItem].Speed;
            wall1.GetComponent<Rigidbody2D>().angularVelocity = wallAtributes[listItem].RotateSpeed;
            wall1.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }

        if (wallAtributes[listItem].SpawnRight)
        {
            GameObject wall2 = Instantiate(wall, new Vector3(yCordSkew, -xCordSkew), Quaternion.AngleAxis(-45, Vector3.forward));
            wall2.GetComponent<Rigidbody2D>().velocity = (Vector2.up + Vector2.left) * wallAtributes[listItem].Speed;
            wall2.GetComponent<Rigidbody2D>().angularVelocity = -wallAtributes[listItem].RotateSpeed;
            wall2.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }
    }

    private void SpawnWallBottomLeft()
    {
        if (wallAtributes[listItem].SpawnLeft)
        {
            GameObject wall1 = Instantiate(wall, new Vector3(-xCordSkew, -yCordSkew), Quaternion.AngleAxis(45, Vector3.forward));
            wall1.GetComponent<Rigidbody2D>().velocity = (Vector2.up + Vector2.right) * wallAtributes[listItem].Speed;
            wall1.GetComponent<Rigidbody2D>().angularVelocity = wallAtributes[listItem].RotateSpeed;
            wall1.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }

        if (wallAtributes[listItem].SpawnRight)
        {
            GameObject wall2 = Instantiate(wall, new Vector3(-yCordSkew, -xCordSkew), Quaternion.AngleAxis(45, Vector3.forward));
            wall2.GetComponent<Rigidbody2D>().velocity = (Vector2.up + Vector2.right) * wallAtributes[listItem].Speed;
            wall2.GetComponent<Rigidbody2D>().angularVelocity = -wallAtributes[listItem].RotateSpeed;
            wall2.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }
    }

    private void SpawnWallTopLeft()
    {
        if (wallAtributes[listItem].SpawnLeft)
        {
            GameObject wall1 = Instantiate(wall, new Vector3(-xCordSkew, yCordSkew), Quaternion.AngleAxis(-45, Vector3.forward));
            wall1.GetComponent<Rigidbody2D>().velocity = (Vector2.down + Vector2.right) * wallAtributes[listItem].Speed;
            wall1.GetComponent<Rigidbody2D>().angularVelocity = wallAtributes[listItem].RotateSpeed;
            wall1.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }

        if (wallAtributes[listItem].SpawnRight)
        {
            GameObject wall2 = Instantiate(wall, new Vector3(-yCordSkew, xCordSkew), Quaternion.AngleAxis(-45, Vector3.forward));
            wall2.GetComponent<Rigidbody2D>().velocity = (Vector2.down + Vector2.right) * wallAtributes[listItem].Speed;
            wall2.GetComponent<Rigidbody2D>().angularVelocity = -wallAtributes[listItem].RotateSpeed;
            wall2.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(wallAtributes[listItem].Thickness, wallLength);
        }
    }

}
