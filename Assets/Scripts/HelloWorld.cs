using UnityEngine;

public class HelloWorld : MonoBehaviour // базовый класс от которого наследуются все остальные
{
    #region Variables 

    private float _score;

    #endregion

    #region Unity lifecycle

    // Start is called before the first frame update
    private void Start() // вызывается постоянно
    {
        Debug.Log("Hello World! :)");
        Debug.LogWarning("Hello World! :)");
        Debug.LogError("Hello World! :)");
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log($"Update {Time.frameCount}");
    } // вызывается в апдейте

    #endregion
}