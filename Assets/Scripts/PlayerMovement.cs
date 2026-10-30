using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 20f;
    public float sidewaysForce = 25f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce);

        if (Keyboard.current.dKey.isPressed)
            rb.AddForce(sidewaysForce, 0, 0);

        if (Keyboard.current.aKey.isPressed)
            rb.AddForce(-sidewaysForce, 0, 0);

        if (rb.position.y < -1f)
            GameManager.instance.EndGame();
    }
}
