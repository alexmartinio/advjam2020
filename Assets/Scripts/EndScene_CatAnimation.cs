using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene_CatAnimation : MonoBehaviour
{

    private SpriteRenderer sr;
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        if (sr == null) return;

        transform.localScale = new Vector3(1, 1, 1);

        float width = sr.sprite.bounds.size.x;
        float height = sr.sprite.bounds.size.y;

        transform.localScale = new Vector2(Screen.width / width, Screen.height / height);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float width = sr.sprite.bounds.size.x;
        float height = sr.sprite.bounds.size.y;

        transform.localScale = new Vector2(Screen.width / width, Screen.height / height);

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
