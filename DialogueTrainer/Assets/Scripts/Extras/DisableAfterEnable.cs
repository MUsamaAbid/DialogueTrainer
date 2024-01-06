using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisableAfterEnable : MonoBehaviour
{
    [SerializeField] GameObject g;
    [SerializeField] float DisableAfter;

    private void OnEnable()
    {
        Invoke("DisableGameobject", DisableAfter);
    }
    private void Awake()
    {
        Invoke("DisableGameobject", DisableAfter);
        Debug.Log("Awake called");
    }
    void DisableGameobject()
    {
        if (!g)
        {
            gameObject.SetActive(false);
        }
        else
        {
            g.SetActive(false);
        }
    }
}
