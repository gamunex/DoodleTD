using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float enemyHealth;
    private float movementSpeed;
    private int killReward;
    private int damage;

    private GameObject targetTile;

    private void Start()
    {
        
    }

    private void initializeEnemy()
    {
        targetTile = MapGenerator.startTile;
    }

    private void moveEnemy()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetTile.transform.position, movementSpeed * Time.deltaTime);
    }

    private void checkPosition()
    {
        if(targetTile != null && targetTile != MapGenerator.endTile)
        {
            float distance = (transform.position - targetTile.transform.position).magnitude;

            if(distance < 0.00f)
            {
                int currentIndex = MapGenerator.pathTiles.IndexOf(targetTile) + 1;
            }
        }
    }

    private void Update()
    {
        
    }
}
