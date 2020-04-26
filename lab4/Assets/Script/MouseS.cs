using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.CompareTag("covid"))
                {
                    Rigidbody rb = hitInfo.collider.GetComponent<Rigidbody>();

                    if (rb)
                        rb.AddForce(-hitInfo.normal * 3, ForceMode.Impulse);

                }
            }
        }
    }

    public void ChangeScence ()
    {
        SceneManager.LoadScene("CharacterFirstPerson");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
