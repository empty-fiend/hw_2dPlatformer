using UnityEngine;

public class PlayerCoinsCollector : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Coin>(out var coin))
        {
            coin.gameObject.SetActive(false);
        }
    }
}
