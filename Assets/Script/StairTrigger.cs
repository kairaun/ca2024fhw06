using UnityEngine;

public class StairTrigger : MonoBehaviour
{
    public Animator characterAnimator; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ���]������ҬO"Player"
        {
            characterAnimator.SetBool("climb", true); // �i�J�ϰ�ɳ]�mclimb��true
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            characterAnimator.SetBool("climb", false); // ���}�ϰ�ɳ]�mclimb��false
        }
    }
}
