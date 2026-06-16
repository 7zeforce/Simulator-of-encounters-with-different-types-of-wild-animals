using UnityEngine;

public class Snake_mov : MonoBehaviour
{
    GameObject target;
    [SerializeField] Animator animator;
    void Start()
    {
        target = Spavn_mob.Instance.Get_position_Plauer();
        gameObject.transform.LookAt(target.transform.position);
    }
    void Update()
    {
        if(Vector3.Distance(gameObject.transform.position,target.transform.position) > 3)
        {
            animator.SetTrigger("SnakeStoit");
        }
        else
        {
            Wasted.Instence.Start_Wasted();
        }
    }
}
