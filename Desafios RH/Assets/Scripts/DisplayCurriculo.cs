using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class DisplayCurriculo : MonoBehaviour
{
    [SerializeField] private Image imageCurriculo;
    [SerializeField] private TextMeshProUGUI namePersonagem;


    private void Start()
    {
        if (SistemaDeSele��o.GetInstance().pessoaAtual.imagemPessoa != null)
        {
            imageCurriculo.sprite = SistemaDeSele��o.GetInstance().pessoaAtual.imagemPessoa;
        }

        namePersonagem.text = SistemaDeSele��o.GetInstance().pessoaAtual.GetNomeCompleto();
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            SistemaDeSele��o.GetInstance().MudarIndiceNext();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            SistemaDeSele��o.GetInstance().MudarIndicePrevious();
        }
    }

    public void SetImageCurriculo(Sprite spr)
    {
        imageCurriculo.sprite = spr;
    }
    public void SetNamePersonagem(string nome)
    {
        namePersonagem.text = nome;
    }

}
