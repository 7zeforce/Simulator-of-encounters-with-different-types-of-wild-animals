using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public static Settings Instance;
    public string languale;
    private void Awake()
    {
        languale = "ru";
        if (Instance == null)
        {
            Instance = this;
        }else if(Instance == this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public void Smena_ru()
    {
        languale = "ru";
        Perevodchik.Instance.Smena_azika();
    }
    public void Smena_us()
    {
        languale = "";
        Perevodchik.Instance.Smena_azika();
    }
}
