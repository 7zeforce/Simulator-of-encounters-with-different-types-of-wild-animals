using UnityEngine;

public class Perevodchik : MonoBehaviour
{
    public static Perevodchik Instance;
    [SerializeField] Storage_text_variant[] storage_Text_Variants;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        Smena_azika();
    }
    public void Smena_azika()
    {
        if(Settings.Instance.languale == "ru")
        {
            foreach(var variants in storage_Text_Variants)
            {
                variants.text.text = variants.Russian;
            }
        }
        else
        {
            foreach(var variants in storage_Text_Variants)
            {
                variants.text.text = variants.amerika;
            }
        }
    }
}
