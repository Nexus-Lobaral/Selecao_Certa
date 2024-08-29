VAR nomePersonagem = ""
VAR nomeJogador = ""
VAR vez = 0 // se for 0 é o jogador, se for 1 é o personagem
VAR contratado = 0 // 1 igual a contratado e 0 igual a rejeitado
VAR qntErros = 2
-> main
=== main ===
~ vez = 0
Olá {nomePersonagem}, prazer, meu nome é {nomeJogador}, podemos começar a entrevista?
~ vez = 1
Com toda certeza!
-> escolhas1
=== escolhas1 ===
~ vez = 0
Escolha uma opção:
    * [O que fez você se interessar pela nossa empresa?]
        Certa resposta!
        -> main2
    * [Que tipo de trabalho você faz? ]
        Ela literalmente quer uma vaga no ramo de designer...acho que é apicultor
        ~ qntErros -= 1
        -> escolhas1
    * [Alguma experiencia em empresas ou e sua primeira vez?]
        No curriculo você encontra essas informações
        ~ qntErros -= 1
        -> escolhas1
=== main2 ===
~ vez = 1
Eu queria fazer o design de outras coisas, sabe? Com um estilo bem parecido com o de vocês
~ vez = 0
Entendi.
-> escolhas2
=== escolhas2 ===
Escolha uma opção:
    * [Que tipo de atividade você pratica no seus dias?]
        Mudança brusca e pergunta desnecessaria
        ~ qntErros -= 1
        -> escolhas2
    * [Você consegue interagir com colegas de trabalho ou com outras pessoas?]
        Otimo, Certa Resposta!
        -> main3
    * [Se sente bem fazendo o seu tipo de design?]
        A entrevistada já mostrou querer fazer outros tipos de design
        ~ qntErros -= 1
        -> escolhas2
=== main3 ===
~ vez = 1
Mas é claro. Consigo tanto com colegas, quanto outras pessoas.
Que bom {nomePersonagem}.
-> escolhas3
=== escolhas3 ===
Escolha uma opção:
    * [Qual tipo de design que você fazia?]
        Isso já foi mostrado em seu curriculo
        ~ qntErros -= 1
        -> escolhas3
    * [--Finalizar entrevista--]
        Ainda pode ser feita uma pergunta sobre uma das preferências do entrevistado
        ~ qntErros -= 1
        -> escolhas3
    * [Como foi chegar aqui?]
        Muito bem, certa resposta!!!
        -> main4
        
=== main4 ===
~ vez = 1
Até que foi facil e como eu planejo trabalhar presencialmente para vocês fica até mais facil.
~ vez = 0
Muito bem, encerramos por aqui. Mandaremos mensagem se tivermos boas novas.

    - -> END // DE qualquer forma ele termina o dialogo