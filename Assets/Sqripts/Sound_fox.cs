using UnityEngine;

public class Sound_fox : MonoBehaviour
{
    [SerializeField] AudioSource krishit;

    public void Krichit()
    {
        krishit.Play();
    }
}
