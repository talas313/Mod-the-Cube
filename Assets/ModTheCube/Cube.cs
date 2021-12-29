using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;

        Material material = Renderer.material;

        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }

    void Update()
    {
        Material m = Renderer.material;
        transform.Rotate(5.0f, 5.0f, 20.0f * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Color randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            float randomNumber = Random.Range(1.0f, 5.0f);
            Vector3 randomVector = new Vector3(randomNumber, randomNumber, randomNumber);
            transform.localScale = randomVector;
            m.color = randomColor;
        }
    }
}
