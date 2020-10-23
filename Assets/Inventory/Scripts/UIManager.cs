using UnityEngine;

namespace Inventory
{
    public class UIManager : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private GameObject menuCanvas = null;

        void Update()
        {
            // If escape key pressed, toggle menu UI
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                menuCanvas.SetActive(!menuCanvas.activeSelf);
            }
        }
    }
}
