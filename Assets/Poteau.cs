using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poteau : MonoBehaviour
{
    [SerializeField] SpriteRenderer _sprite;
    [SerializeField] int _startHealth;
    [SerializeField] Sprite _2health;
    [SerializeField] Sprite _1health;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Player.IsPlayer(collision))
        {
            Debug.Log("ah");
            _startHealth--;

            if (_startHealth <= 0)
            {
                Destroy(gameObject);
            }
            else if (_startHealth == 2)
            {
                _sprite.sprite = _2health;
            }
            else if (_startHealth == 1)
            {
                _sprite.sprite = _1health;

            }
        }

    }


}
