using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public GameObject destroyEffect;
    

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void DestroyProjectile()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        SoundManagerScript.PlaySounds("explosion");
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {
            DestroyProjectile();
        }
    }
}
