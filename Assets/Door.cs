using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] SpriteRenderer _renderer;
    [SerializeField] Sprite _openDoorSprite;

    [SerializeField] string _sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Player.IsPlayer(collision))
        {
            StartCoroutine(  OpenRoutine()  );
        }
    }

    IEnumerator OpenRoutine()
    {
        // On change le sprite
        _renderer.sprite = _openDoorSprite;

        // On attend X secondes
        yield return new WaitForSeconds(3);

        // Puis on lance la scene
        SceneManager.LoadScene(_sceneName);
    }



}
