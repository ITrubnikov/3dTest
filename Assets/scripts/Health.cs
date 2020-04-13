using UnityEngine;
using System.Collections;

public class Health: MonoBehaviour
{
    public float CurrentHealth;
    public SpriteRenderer Renderer;
    private float MaxValue;
    // Use this for initialization
    void Start()
    {
        MaxValue = CurrentHealth;
        Renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    public void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
        Renderer.color = Color.Lerp(Color.red, Color.white, CurrentHealth / MaxValue);
        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
