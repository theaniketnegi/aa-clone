using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Arrow : MonoBehaviour
{
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Circle")
        {
            transform.SetParent(collision.transform);
            UIManager.score++;
            Destroy(rb);
        }
        if (collision.gameObject.tag == "Arrow")
        {
            StartCoroutine("ReloadScene");
        }
    }
    IEnumerator ReloadScene()
    {
        Camera.main.GetComponent<Camera>().backgroundColor = Color.red;
        ArrowSpawner.canThrow = false;
        yield return new WaitForSeconds(.1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
