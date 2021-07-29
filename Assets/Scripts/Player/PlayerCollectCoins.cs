using UnityEngine;

public class PlayerCollectCoins : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        var isCoinFounded = collision.gameObject.TryGetComponent<Coin>(out var coin);

        if (isCoinFounded)
        {
            coin.gameObject.SetActive(false);
        }
    }
}
