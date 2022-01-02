using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spit : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _lifetime;
    [SerializeField] private int _damage;    

    private void Start()
    {
        StartCoroutine(DestroyItself());
    }

    private void Update()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            player.ApplyDamage(_damage);

            Destroy(gameObject);
        }

    }

    private IEnumerator DestroyItself()
    {
        yield return new WaitForSeconds(_lifetime);

        Destroy(gameObject);
    }
}
