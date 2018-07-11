using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerMenu : MonoBehaviour
{
    private static bool sPause = false;

    [SerializeField] bool m_DontDestroyLoad = true;
    [SerializeField] KeyCode btPause = KeyCode.P;
    [SerializeField] bool m_Pause;

    void Awake()
    {
        if (m_DontDestroyLoad) { DontDestroyOnLoad(gameObject); } //Evita que o Objeto seja destruido nas troca de cenas;
    }

    // Use this for initialization
    void Start()
    {
        sPause = false;
    }

    // Update is called once per frame
    void Update()
    {
        m_Pause = sPause;

        if (Input.GetKeyDown(btPause))
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name.Equals("Game"))
            {
                sPause = !sPause;

                if (sPause) { Time.timeScale = 0f; }
                else { Time.timeScale = 1f; }
            }
        }
    }

    public void OnClickPlay()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public static bool isPaused() { return sPause; }
}
