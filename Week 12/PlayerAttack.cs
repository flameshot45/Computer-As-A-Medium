using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    public GameObject bulletPrefab;

    public Transform firePoint;

    public GameObject castText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Attack()
    {
        if (Keyboard.current.fKey.isPressed)
        {
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);
        }
    }

    void Shoot()
    {
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            StartCoroutine(CastText());
        }
    }

    IEnumerator CastText()
    {
    castText.SetActive(true);
    yield return new WaitForSeconds(.5f);
    castText.SetActive(false);
    }
}
