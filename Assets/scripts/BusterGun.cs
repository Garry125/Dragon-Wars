using UnityEngine;
using System.Collections;

public class BusterGun : MonoBehaviour
{
    Animator mAnimator;
    bool mShooting;

    float kShootDuration = 0.25f;
    float mTime;

    public GameObject mBulletPrefab;
    MegaMan mMegaManRef;
    
    AudioSource mBusterSound;

    void Start ()
    {
        mAnimator = transform.parent.GetComponent<Animator>();
        
        mMegaManRef = GameObject.Find("player").GetComponent<MegaMan>();
        mBusterSound =GameObject.Find("Fire").GetComponent<AudioSource>();
    }

    void Update ()
    {
        if(Input.GetButtonDown ("Fire"))
        {
            
            GameObject bulletObject = Instantiate(mBulletPrefab, transform.position, Quaternion.identity
                );       
            Vector2 bulletdirection = mMegaManRef.GetFacingDirection();
            Bullet cc = bulletObject.GetComponent<Bullet>();

            cc.SetDirection(bulletdirection);
            
               mBusterSound.Play();

            
            mShooting = true;
            mTime = 0.0f;
        }

        if(mShooting)
        {
            mTime += Time.deltaTime;
            if(mTime > kShootDuration)
            {
                mShooting = false;
            }
        }

        UpdateAnimator();
    }

    private void UpdateAnimator()
    {
        mAnimator.SetBool ("isShooting", mShooting);
    }
}
