using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPresenter : Presenter
{
    [SerializeField] private int _reward;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IBullet bullet))
            Die();
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }
}
