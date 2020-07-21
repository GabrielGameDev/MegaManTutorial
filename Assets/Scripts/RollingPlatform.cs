using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingPlatform : MonoBehaviour
{

    public int direction = 1;
    public float force = 10;
    public SpriteRenderer[] spriteRenderers;
    public Sprite left, right, empty;

    private List<Rigidbody2D> rbs = new List<Rigidbody2D>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Rolling());
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < rbs.Count; i++)
        {
            rbs[i].AddForce(Vector2.right * direction * force);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Rigidbody2D newRb = other.gameObject.GetComponent<Rigidbody2D>();
        if(newRb != null)
        {
            rbs.Add(newRb);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Rigidbody2D newRb = other.gameObject.GetComponent<Rigidbody2D>();
        if (newRb != null)
        {
            if (rbs.Contains(newRb))
            {
                rbs.Remove(newRb);
            }
        }
    }

    IEnumerator Rolling()
    {
        while (true)
        {
            if(direction > 0)
            {
                for (int i = 0; i < spriteRenderers.Length; i++)
                {
                    spriteRenderers[i].sprite = empty;
                }
                yield return new WaitForSeconds(0.1f);
                for (int i = 0; i < spriteRenderers.Length; i++)
                {
                    spriteRenderers[i].sprite = right;
                }
                yield return new WaitForSeconds(0.1f);
            }
            else
            {
                for (int i = 0; i < spriteRenderers.Length; i++)
                {
                    spriteRenderers[i].sprite = empty;
                }
                yield return new WaitForSeconds(0.1f);
                for (int i = 0; i < spriteRenderers.Length; i++)
                {
                    spriteRenderers[i].sprite = left;
                }
                yield return new WaitForSeconds(0.1f);
            }
        }
    }

    public void Clean()
    {
        rbs.Clear();
    }
}
