-> main
VAR nomePersonagem = ""
VAR nomeJogador = ""
VAR vez = 0 // se for 0 é o jogador, se for 1 é o personagem
VAR qntErros = 2
=== main ===
~ vez = 0
Olá {nomePersonagem}, podemos começar?
~ vez = 1
À vontade.
-> escolhas1
=== escolhas1 ===
~ vez = 0
Escolha uma opção:
    * [Qual sua experiência nessa área?]
        Em seu currículo foi mostrado seus cursos
        ~ qntErros -= 1
        -> escolhas1
    * [Como você definiria nossa empressa?] 
        Essa pergunta não é muito boa para o início de diálogo
        ~ qntErros -= 1
        -> escolhas1
    * [O que te fez se interessar pela vaga?] // CERTA RESPOSTA
        Muito bem, certa resposta!!!
        -> main2
=== main2 ===
~ vez = 1
Bom, eu apenas fiquei estudando e cursando na área de programação, então eu só estava esperando aparecer uma vaga mesmo.
~ vez = 0
Compreensível.
-> escolhas2
=== escolhas2 ===
Escolha uma opção:
    * [Gostei da blusa.]
        Pra que essa afirmação aleatória?
        ~ qntErros -= 1
        -> escolhas2
    * [Você sabe se comunicar?]
        Muito bem, certa resposta!!!
        -> main3
    * [Se sente seguro de suas capacidades?]
        Essa pergunta não se encaixa muito bem na situação atual... quem sabe no futuro
        ~ qntErros -= 1
        -> escolhas2
=== main3 ===
~ vez = 1
Depende bastante, sabe, porque eu sei interagir muito bem com pessoas do meu rumo social, mas de resto não tenho muita confiança.
~ vez = 0
Entendi.
-> escolhas3
=== escolhas3 ===
Escolha uma opção:
    * [O que você aprendeu nos seus cursos?]
        "Na área de programação" hmmm provavelmente culinaria.
        ~ qntErros -= 1
        -> escolhas3
    * [Você tem muitos projetos no seu currículo, poderia falar como foi fazê-los?]
        Foi mostrado no seu currículo e foram poucos projetos feitos.
        ~ qntErros -= 1
        -> escolhas3
    * [Não vi muito de seus projetos no seu currículo, por acaso você não fez tantos assim?]// CERTA RESPOSTA
        Certa Resposta!
        -> main4
=== main4 ===
~ vez = 1
Eu não consigo fazer muitos... tenho um problema quando tento fazê-los.
~ vez = 0
Que tipo de problema?
~ vez = 1
Eu não sei explicar, só sinto que não consigo.
-> escolhas4
=== escolhas4 ===
Escolha uma opção:
    * [Pode explicar melhor?]
        Ela já disse que não sabe explicar
        ~ qntErros -= 1
        -> escolhas4
    * [Quer conversar?]
        Mantenha uma postura profissional
        ~ qntErros -= 1
        -> escolhas4
    * [Você se sente insegura com suas habilidades?] // CERTA RESPOSTA
        Certa Resposta!
        -> main5
=== main5 ===
~ vez = 1
Insegura seria meio que um eufemismo haha... mas sim... (Começa a lacrimejar)
~ vez = 0
Olha, se--
~ vez = 1
Olha! Eu não sei, tá bom! Eu só... eu...
~ vez = 1
Eu não tô legal hoje... sei que não vou conseguir nada. Pode entregar a vaga para outro (Sai da sala chorando).

    - -> END // DE qualquer forma ele termina o dialogo
