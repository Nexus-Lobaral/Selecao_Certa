using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// [CreateAssetMenu(fileName = "Create Personagem", menuName = "New Personagem")]
public class PersonagemData : MonoBehaviour /* ScriptableObject */
{
    List<GameObject> personagens;
    [SerializeField] private Pessoa pessoa;
    [SerializeField] private List<TextAsset> jsonFiles = new List<TextAsset>(10);

    private void Start()
    {
        CriarPessoas();
    }
    
    
    public void CriarPessoas()
    {
        personagens = new List<GameObject>(10);
        
        foreach(GameObject personagem in personagens)
        {
            // personagem.AddComponent<jsonFiles[Random.Range(0, 9)]>();
        }
    }

    // Talvez esse sera o script de criar personagens

}
