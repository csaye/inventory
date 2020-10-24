using UnityEngine;

namespace Inventory
{
    public class UIManager : MonoBehaviour
    {
        public static bool menuOpen {get; private set;} = false;

        [Header("References")]
        [SerializeField] private GameObject menuCanvas = null;

        private void Start()
        {
            menuOpen = false;
            menuCanvas.SetActive(false);
        }

        private void Update()
        {
            // If escape key pressed, toggle menu UI
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                menuCanvas.SetActive(!menuCanvas.activeSelf);
                menuOpen = menuCanvas.activeSelf;
            }
        }
    }
}
