using UnityEngine;

public class Coin : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0, 2, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddCoin();
            Destroy(gameObject);
        }
    }
}
