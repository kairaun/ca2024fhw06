using UnityEngine;

public class StairTrigger : MonoBehaviour
{
    public Animator characterAnimator; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 假設角色標籤是"Player"
        {
            characterAnimator.SetBool("climb", true); // 進入區域時設置climb為true
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            characterAnimator.SetBool("climb", false); // 離開區域時設置climb為false
        }
    }
}
