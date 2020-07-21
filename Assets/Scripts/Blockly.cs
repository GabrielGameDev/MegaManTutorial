using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockly : MonoBehaviour
{
    public Scroller scroller;
    private Animator animator;

    private bool walk = true;

    private Transform player;

    public LayerMask groundLayer;

    public GameObject[] blocklys;
    public Rigidbody2D blocklyPrefab;

    private void Awake()
    {
        animator = GetComponent<Animator>();        
    }

    private void Start()
    {
        scroller.enabled = true;
        player = FindObjectOfType<PlayerMovement>().transform;
        StartCoroutine(Behaviour());

    }

    IEnumerator Behaviour()
    {
        yield return StartCoroutine(Walk());
        yield return StartCoroutine(ReadyToShoot());
        yield return StartCoroutine(Shoot());
        yield return StartCoroutine(Reset());
        StartCoroutine(Behaviour());
    }

    IEnumerator Walk()
    {
        while (walk)
        {
            RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - 1), Vector2.right * scroller.speed.x, 0.5f, groundLayer);

            Color color = hit ? Color.red : Color.green;

            Debug.DrawRay(new Vector2(transform.position.x, transform.position.y -1), Vector2.right * scroller.speed.x, color);

            if (hit)
                scroller.enabled = false;

            float distance = Vector2.Distance(transform.position, player.position);
            if(distance < 10)
            {
                yield return new WaitForSeconds(1);
                walk = false;
            }
            yield return null;
        }
    }

    IEnumerator ReadyToShoot()
    {
        animator.enabled = false;
        scroller.enabled = false;      
        yield return new WaitForSeconds(1);
        
    }

    IEnumerator Shoot()
    {
        List<Rigidbody2D> newBloclys = new List<Rigidbody2D>();
        for (int i = 0; i < blocklys.Length; i++)
        {            
            blocklys[i].SetActive(false);
            Rigidbody2D newBlockly = Instantiate(blocklyPrefab, blocklys[i].transform.position, Quaternion.identity);
            newBlockly.AddForce(new Vector2(Random.Range(-15f, -10f), 4), ForceMode2D.Impulse);
            newBloclys.Add(newBlockly);
        }
        yield return new WaitForSeconds(3);
        for (int i = 0; i < newBloclys.Count; i++)
        {
            Destroy(newBloclys[i].gameObject);
        }

    }

    IEnumerator Reset()
    {
        for (int i = 0; i < blocklys.Length; i++)
        {
            blocklys[i].SetActive(true);           
        }
        animator.enabled = true;        
        scroller.enabled = true;
        walk = true;
        yield return null;

    }
}
