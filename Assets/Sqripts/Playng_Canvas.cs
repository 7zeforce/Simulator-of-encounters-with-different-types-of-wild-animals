using UnityEngine;
using UnityEngine.UI;

public class Playng_Canvas : MonoBehaviour
{
    Wasted wasted;
    [SerializeField] Menu_Caanvas menu_Canvas;
    [SerializeField] string[] text_variants_ru;
    [SerializeField] string[] text_variants_ue;
    [SerializeField] Text glav_text;
    [SerializeField] Text buton_text;
    string ful_text;
    int nomer_txta;
    int kol_simvolov = 0;
    int max_kol_simvolov = 176;
    int simvol_prochitani;
    private void Start()
    {
        simvol_prochitani = max_kol_simvolov;
        wasted = Wasted.Instence;
    }
    public void Glav_text()
    {
      nomer_txta = menu_Canvas.Get_variant_texta();
        if (Settings.Instance.languale == "ru")
        {
                glav_text.text = text_variants_ru[nomer_txta];
                buton_text.text = "продолжить";
        }
        else
        {
                glav_text.text = text_variants_ue[nomer_txta];
                buton_text.text = "next";
        }
        ful_text = glav_text.text;
        for (int i = 0; i < ful_text.Length; i++)
        {
                kol_simvolov += 1;
        }
    }
    public void Button_nashat()
    {
        if (buton_text.text == "продолжить" || buton_text.text == "next")
        {
                glav_text.text = "";
                for (int i = 0; i < kol_simvolov; i++)
                {
                    if (i >= simvol_prochitani)
                    {
                        glav_text.text += ful_text[i];
                    }
                }
                simvol_prochitani += max_kol_simvolov;
            if(simvol_prochitani > kol_simvolov)
            {
                if (Settings.Instance.languale == "ru")
                {
                    buton_text.text = "начать";
                }
                else
                {
                    buton_text.text = "begin";
                }
            }
        }
        else
        {
            gameObject.SetActive(false);
            wasted.Start_spavn(nomer_txta);
        }
    }
}
