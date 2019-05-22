using UnityEngine;
using UnityEngine.Events;

public class PlayerEventController : MonoBehaviour
{
    [HideInInspector] public UnityEvent Attack;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) Attack.Invoke();
    }
}
