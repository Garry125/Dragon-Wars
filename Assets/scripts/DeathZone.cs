using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour

{
    [SerializeField]
    GameObject mDeathParticleEmitter;

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("death"))
        {
            Instantiate(mDeathParticleEmitter, transform.position, Quaternion.identity);
            Destroy(gameObject);
            SceneManager.LoadScene("Gameover");

        }
        
    }
}
