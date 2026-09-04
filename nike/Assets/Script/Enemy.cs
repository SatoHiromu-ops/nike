using UnityEngine;

public class Target : MonoBehaviour
{
    public int maxHitCount = 5;

    private int currentHitCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        // íeÉ^ÉOÇ»ÇÁ
        if (collision.gameObject.CompareTag("Bullet"))
        {
            currentHitCount++;

            Debug.Log("Hit : " + currentHitCount);

            // 5âÒìñÇΩÇ¡ÇΩÇÁè¡Ç¶ÇÈ
            if (currentHitCount >= maxHitCount)
            {
                Destroy(gameObject);
            }

            // íeÇ‡è¡Ç∑
            Destroy(collision.gameObject);
        }
    }
}