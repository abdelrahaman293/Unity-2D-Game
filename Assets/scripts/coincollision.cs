using UnityEngine;

public class coinCollisison : MonoBehaviour
{
    public AudioSource soundCoin;

    private bool collected = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collected) return;

        collected = true;
        score.score_val += 10;

        if (soundCoin != null && soundCoin.clip != null)
        {
            AudioSource.PlayClipAtPoint(
                soundCoin.clip,
                transform.position
            );
        }

        Destroy(gameObject);
    }
}