using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox_move : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject target;
    [SerializeField] Animator animator;
    float speed = 8;
    void Start()
    {
        target = Spavn_mob.Instance.Get_position_Plauer();
        gameObject.transform.LookAt(target.transform.position);
    }
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, target.transform.position) > 3)
        {
            animator.SetTrigger("Beg");
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,1.2f,gameObject.transform.position.z);
            gameObject.transform.LookAt(target.transform.position);
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, target.transform.position, speed * Time.deltaTime);
        }
        else
        {
            animator.SetTrigger("Stoit");
            speed = 0;
            StartCoroutine(TimerFox());
        }
    }
    private IEnumerator TimerFox()
    {
        yield return new WaitForSeconds(3f);
        Wasted.Instence.Start_Wasted();
    }
}
