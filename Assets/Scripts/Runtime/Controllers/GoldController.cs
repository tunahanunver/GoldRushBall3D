using UnityEngine;

public class GoldController : MonoBehaviour
{
    public int goldValue = 1; // Altının değeri, istediğiniz gibi değiştirebilirsiniz.
    public GoldManager goldManager; // Puanları tutacak GameManager referansı.

    void OnTriggerEnter(Collider other)
    {
        // Eğer karakter altını toplarsa
        if (other.CompareTag("Player"))
        {
            // Puanı artır
            goldManager.AddScore(goldValue);

            // Altını yok et
            Destroy(gameObject);
        }
    }
}