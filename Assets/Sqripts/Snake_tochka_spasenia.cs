using UnityEngine;

public class Snake_tochka_spasenia : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Wasted.Instence.Start_win();
        }
    }
}
