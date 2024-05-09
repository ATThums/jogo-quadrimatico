using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickQuad : MonoBehaviour
{
    Rigidbody2D rig;
    CircleCollider2D circleColl;
    Camera cam;

    public static bool isCutting;

    Vector2 lastPos;
    
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        rig = GetComponent<Rigidbody2D>();
        circleColl = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCut();
        }

        else if(Input.GetMouseButtonUp(0))
        {
            StopCut();
        }

        if(isCutting)
        {
            UpdateCut();
        }
    }

    void UpdateCut()
    {
        Vector2 newPos = cam.ScreenToWorldPoint(Input.mousePosition);
        rig.position = newPos;

        float velocity = (newPos - lastPos).magnitude * Time.deltaTime;

        lastPos = newPos;
    }

    void StartCut()
    {
        isCutting = true;
        circleColl.enabled = true;
        NovoSpawner.clicou = true;
        movimentoUp.cutting = true;

    }

    void StopCut()
    {
        isCutting = false;
        circleColl.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Numero")
        {
            StopCut();
        }

    }
}
