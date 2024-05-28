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
Certamente.
-> escolhas1
=== escolhas1 ===
~ vez = 0
Escolha uma opção:
    * [Você tem experiência na área?]
        Já foi mostrado no currículo
        ~ qntErros -= 1
        -> escolhas1
    * [O que te interessou na vaga?]
        Certa resposta!
        -> main2
    * [É sua primeira vez em uma entrevista?]
        O cara já teve um emprego, então acho que nunca teve, né?
        ~ qntErros -= 1
        -> escolhas1
=== main2 ===
~ vez = 1
Bom, era uma oportunidade, já que eu queria sair da minha empresa antiga.
~ vez = 0
Então você apenas queria sair da sua antiga empresa?
~ vez = 1
Não é só por causa disso, mas sim.
-> escolhas2
=== escolhas2 ===
~ vez = 0
Escolha uma opção:
    * [Teve a ver com seu trabalho?]
        Otimo, Certa Resposta!
        -> main3
    * [Qual era a empresa?]
        Você tem que se focar na sua, não na dos outros
        ~ qntErros -= 1
        -> escolhas2
    * [Isso afetará no seu desempenho?]
        Que isso, cara, a gente esconde quando não se importa
        ~ qntErros -= 1
        -> escolhas2
=== main3 ===
~ vez = 1
Tecnicamente não, porque eles eram muito desorganizados e nada focados.
~ vez = 0
Então você apenas se incomodou com o jeito deles. Entendo.
-> escolhas3
=== escolhas3 ===
Escolha uma opção:
    * [Conta mais sobre essa empresa.]
        Foque na entrevista, não no drama empresarial
        ~ qntErros -= 1
        -> escolhas3
    * [Deve ter sido complicado, mas a nossa é bem organizada.]
        Você não sabe se vai ser, então se tá mentindo... e mentir é para político
        ~ qntErros -= 1
        -> escolhas3
    * [Como que você trabalha?]
        Muito bem, certa resposta!!!
        -> main4
        
=== main4 ===
~ vez = 1
Bom, eu tento deixar tudo o mais organizado possível e sou bem calmo, porém sou rígido e bravo sempre que for necessário.
~ vez = 0
Muito bem, espere um instante, irei decidir o seu caso.
Escolha uma opção:
    * [Contratar]
        ~ contratado = 1
        Parabens, Acabei de decidir que vamos te contratar
    * [Rejeitar]
        ~ contratado = 0
        Infelizmente vou te rejeitar, tente na proxima

    - -> END // DE qualquer forma ele termina o dialogo