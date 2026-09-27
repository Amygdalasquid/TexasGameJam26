using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathSystem : MonoBehaviour
{
    
    public static DeathSystem instance;
    public GameObject Container;

    private void Awake()
    {
        instance = this;
    }
    public void EnableDeathScreen()
    {
        Container.SetActive(true);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
