using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;
    public int live;
    public Transform liveBar; // barra da vida
    public GameObject objBar; // agrupar a barra
    private Vector3 barScale; // tamanho
    private float barPercent; // Percentual de vida

    void Start()
    {
        barScale = liveBar.localScale; // pegar o tamanho da barra
        barPercent = barScale.x / live; // calcular vida
    }

    void UpdateLiveBar()
    {
        barScale.x = barPercent * live;
        liveBar.localScale = barScale;
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown("u"))
        {
            if(live > 0){
                live = live - 1;
                UpdateLiveBar();
            }
            
        }
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    //Atualiza 15 vezes por segundo, independente do framerate
    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
