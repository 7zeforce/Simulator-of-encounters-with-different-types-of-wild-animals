using UnityEngine;
using System.Collections;
using Valve.VR.InteractionSystem;

public class Bear_mov : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject target;
    [SerializeField] Animator animator;
    float speed = 3;
    private void Start()
    {
        target = Spavn_mob.Instance.Get_position_Plauer();
        gameObject.transform.LookAt(target.transform.position);
    }
    private void FixedUpdate()
    {
        if (Vector3.Distance(gameObject.transform.position, target.transform.position) > 10)
        {
            animator.SetTrigger("idet");
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);
            gameObject.transform.LookAt(target.transform.position);
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position,target.transform.position,speed * Time.deltaTime);  
        }
        else
        {
            animator.SetTrigger("Stoit");
            speed = 0;
            StartCoroutine(TimerBear());
        }
    }
    private IEnumerator TimerBear()
    {
        yield return new WaitForSeconds(3f);
        Wasted.Instence.Start_Wasted();
    }
}
