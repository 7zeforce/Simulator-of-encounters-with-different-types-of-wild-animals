using UnityEngine;

public class Spavn_mob : MonoBehaviour
{
    public static Spavn_mob Instance;
    [SerializeField] GameObject[] mobs;
    [SerializeField] GameObject Obxode_snake;
    [SerializeField] GameObject toshkaspavn;
    [SerializeField] GameObject toshkaspavn_snake;
    [SerializeField] GameObject Player;
    private void Awake()
    {
        Instance = this;
    }
    public void Spavn_Mob(int value)
    {
        if(value != 2)
        {
            Instantiate(mobs[value], toshkaspavn.transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(mobs[value], toshkaspavn_snake.transform.position, Quaternion.identity);
            Obxode_snake.SetActive(true);
        }
    }
    public GameObject Get_position_Plauer() => Player;
}
