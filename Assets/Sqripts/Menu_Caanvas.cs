using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Caanvas : MonoBehaviour
{
    [SerializeField] Playng_Canvas playng_Canvas;
    [SerializeField] GameObject panelVibor;
    [SerializeField] GameObject panel_Settings;
    [SerializeField] GameObject panel_Start;
    [SerializeField] GameObject panel_Igri;
    int variant_texta;
    public void New_play()
    {
        panelVibor.SetActive(true);
        panel_Start.SetActive(false);
    }
    public void Button_baek_Start()
    {
        panelVibor.SetActive(false);
        panel_Start.SetActive(true);
    }
    public void Exit_game()
    {
        Application.Quit();
    }
    public void SmenaRus_button()
    {
        Settings.Instance.Smena_ru();
    }   
    public void SmenaUS_button()
    {
        Settings.Instance.Smena_us();
    }
    public void Button_Setings_On()
    {
        panel_Start.SetActive(false);
        panel_Settings.SetActive(true);
    }
    public void Button_Setings_Of()
    {
        panel_Start.SetActive(true);
        panel_Settings.SetActive(false);
    }
    public void Button_Bear()
    {
        variant_texta = 0;
        panelVibor.SetActive(false);
        panel_Igri.SetActive(true);
        playng_Canvas.Glav_text();
    }
    public void Button_Fox()
    {
        variant_texta = 1;
        panel_Igri.SetActive(true);
        panelVibor.SetActive(false);
        playng_Canvas.Glav_text();
    }
    public void Button_snake()
    {
        variant_texta = 2;
        panel_Igri.SetActive(true);
        panelVibor.SetActive(false);
        playng_Canvas.Glav_text();
    }
    public int Get_variant_texta() => variant_texta;
}
