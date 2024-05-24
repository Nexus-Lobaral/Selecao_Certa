-> main
VAR nomePersonagem = ""

=== main ===
Escolha uma fruta:
    + [Uva]
        -> chosen("Uva")
    + [Maçã]
        -> chosen("Maçã")
    + [Laranja]
        -> chosen("laranja")

=== chosen(fruta) == 
{nomePersonagem} escolheu {fruta}!
-> END