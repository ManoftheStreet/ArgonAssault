using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log($"{other.gameObject.name} 에 맞았다");
        Destroy(gameObject);
    }
}
