using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth = 3;
    public int maxHealth = 3;

    public TMP_Text healthText;
    public Animator healthTextAnim;

    private void Start()
    {
        healthText.text = "HP: " + currentHealth + " / " + maxHealth;
    }

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        healthTextAnim.Play("Text_Update");
        healthText.text = "HP: " + currentHealth + " / " + maxHealth;

        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
        else if(currentHealth <= 0)
            gameObject.SetActive(false);

    }
}
