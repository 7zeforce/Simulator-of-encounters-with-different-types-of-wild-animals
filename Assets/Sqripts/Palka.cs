using UnityEngine;

public class Palka : MonoBehaviour
{
    int kol_kosania = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "fox")
        {
            kol_kosania += 1;
            if (kol_kosania > 3)
            {
                Wasted.Instence.Start_win();
            }
        }
    }
}
