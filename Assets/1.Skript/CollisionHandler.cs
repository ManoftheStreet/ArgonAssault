using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.gameObject.name}ø° ¡¢√À");
        StartCrashSequence();
    }

    private void StartCrashSequence()
    {
        GetComponent<PlayerController>().SetLaserActive(false);
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<PlayerController>().enabled = false;
        Invoke("RekiadLevel", loadDelay);
    }

    void RekiadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
