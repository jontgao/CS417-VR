using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Light light;
    public InputActionReference action;
    void Start()
    {
        light = GetComponent<Light>();

        if (action) // todo: fix this
        {
            light.color = new Color(255, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
