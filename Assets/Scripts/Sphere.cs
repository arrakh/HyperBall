using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sphere : MonoBehaviour
{
    [SerializeField] private Material trailMat;
    [SerializeField] private Material deadParticleMat;
    [SerializeField] private Material bounceParticleMat;
    [SerializeField] private ParticleSystem deadParticle;
    [SerializeField] private ParticleSystem bounceParticle;

    private Color lastColor;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Time.timeScale = 1f;

        //trailMat.SetColor("_Color", Color.white);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        Debug.Log("TESTING");

        rb.isKinematic = true;

        //deadParticleMat.SetColor("_Color", lastColor);
        deadParticle.Play();

        Invoke("Restart", 3f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //lastColor = RandomColor();
        //GetComponent<Renderer>().material.SetColor("_EmissionColor", lastColor);
        //trailMat.SetColor("_Color", lastColor);
        //bounceParticleMat.SetColor("_Color", lastColor);

        bounceParticle.Play();

        collision.gameObject.GetComponent<Tilt>().StartTilt(transform.position);

        GameManager.Instance.Point++;
    }

    Color RandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
