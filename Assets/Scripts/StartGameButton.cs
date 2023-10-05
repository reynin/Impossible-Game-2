using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class StartGameButton : MonoBehaviour
    {
        void FixedUpdate()
        {
            transform.Rotate(1,1,1);
        }
        
        public void HoverStart()
        {
            transform.localScale = Vector3.one * 1.1f;
        }

        public void HoverEnd()
        {
            transform.localScale = Vector3.one;
        }

        public void ClickStart()
        {
            MeshRenderer mr = GetComponent<MeshRenderer>();
            mr.material.color = Color.gray;
            mr.material.SetColor(" EmissionColor", Color.grey);
        }

        public void ClickEnd()
        {
            MeshRenderer mr = GetComponent<MeshRenderer>();
            mr.material.color = Color.white;          
            mr.material.SetColor(" EmissionColor", Color.white);

        }

        public void Click()
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}