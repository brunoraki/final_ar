using UnityEngine;

public class WindowOpener : MonoBehaviour
{
    public Animator animator; // Assign this in the Inspector

    public void OpenWindow()
    {
        if (animator == null)
        {
            Debug.LogError("Animator not assigned to WindowOpener!");
            return;
        }

        animator.SetTrigger("Open");
    }
}
