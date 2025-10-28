using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneNavigator : MonoBehaviour
{
    private void Update()
    {
        QuitApplication();
        ResetScene();
    }
    private void QuitApplication()
    {
        if (Keyboard.current.escapeKey.isPressed)
        {
            Application.Quit();
        }
    }
    
    private void ResetScene()
    {
        if (Keyboard.current.rKey.isPressed)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
