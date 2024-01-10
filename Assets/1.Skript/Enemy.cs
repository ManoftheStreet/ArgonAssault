using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    [SerializeField] GameObject hitVFX;
    [SerializeField] int hitPoint = 2;
    [SerializeField] int scorePerHit = 50;

    ScoreBoard scoreBoard;
    GameObject parentGameObject;

    void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
        parentGameObject = GameObject.FindWithTag("Spawn");
        AddRigidbody();
    }

    void AddRigidbody()
    {
        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        if (hitPoint < 1)
        {
            KillEnemy();
        }
    }

    void ProcessHit()
    {
        if (hitVFX != null && parentGameObject != null)
        {
            GameObject vfx = Instantiate(hitVFX, transform.position, Quaternion.identity);
            vfx.transform.parent = parentGameObject.transform;
        }
        hitPoint--;
    }

    void KillEnemy()
    {
        if (deathFX != null && parentGameObject != null)
        {
            GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
            fx.transform.parent = parentGameObject.transform;
        }
        scoreBoard.IncreaseScore(scorePerHit);
        Destroy(gameObject);
    }
}
