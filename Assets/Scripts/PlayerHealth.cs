using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth = 3;
    public int maxHealth = 3;

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;

        if(currentHealth > maxHealth)
            currentHealth = maxHealth;
        else if(currentHealth <= 0)
            gameObject.SetActive(false);

    }
}
