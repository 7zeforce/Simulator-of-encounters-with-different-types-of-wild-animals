using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Button_clic : MonoBehaviour
{
    [SerializeField] SteamVR_Action_Boolean trigger;
    bool isStay = false;

    private void Update()
    {
        if(isStay && trigger.GetLastStateDown(SteamVR_Input_Sources.Any))
        {
            GetComponent<Button>().onClick.Invoke();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "ruka")
        {
            isStay = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "ruka")
        {
            isStay = false;
        }
    }
}
