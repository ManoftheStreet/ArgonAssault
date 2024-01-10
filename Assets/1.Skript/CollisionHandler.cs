using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem crashVFX;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.gameObject.name}ø° ¡¢√À");
        StartCrashSequence();
    }

    void StartCrashSequence()
    {
        if(crashVFX != null )
        {
            crashVFX.Play();
        }

        GetComponent<PlayerController>().SetLaserActive(false);
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<PlayerController>().enabled = false;
        Invoke("ReloadLevel", loadDelay);
    }

    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
