using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Collections;

public class Wasted : MonoBehaviour
{
    public static Wasted Instence;
    [SerializeField] GameObject panel_lose;
    [SerializeField] GameObject panel_Win;
    [SerializeField] GameObject panel_paly;
    [SerializeField] Text text_timer;
    float timer = 6;
    bool raz = false;
    private void Awake()
    {
        Instence = this;
    }
    private void Start()
    {
        raz = true;
    }
    public void Start_Wasted()
    {
        if (raz)
        {
            panel_lose.SetActive(false);
            panel_lose.SetActive(true);
            StartCoroutine(Timer());
        }
    }
    public void Start_win()
    {
        raz = false;
        panel_lose.SetActive(false);
        panel_Win.SetActive(true);
        StartCoroutine(Timer());
    }
    public void Start_spavn(int value)
    {
        panel_paly.SetActive(true);
        StartCoroutine(Timer_poavlenia(value));
    }
    private IEnumerator Timer_poavlenia(int value)
    {
        timer = 6;
        while(timer > 0)
        {
            timer -= 0.1f;
            text_timer.text = String.Format("{0:0}", timer);
            yield return new WaitForSeconds(0.1f);
        }
        panel_paly.SetActive(false) ;
        Spavn_mob.Instance.Spavn_Mob(value);
    }
    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }
}
