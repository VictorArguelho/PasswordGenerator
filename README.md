# Password Generator

Aplicativo de console simples feito em C#. Ele usa um padrão para transformar o nome de um site/app em uma senha, assim permitindo ter uma senha diferente em cada conta, para evitar vazar senhas.

## Funcionamento

O usuário entra o nome da plataforma, e diz se a senha deve ser forte ou não, em seguida, o programa usa o nome da plataforma para gerar uma senha seguindo o seguinte padrão:
- 1º Caractere -> 2 letras anteriores a 1ª letra da entrada (C -> A | A -> Y) maiúscula;
- 2º Caractere -> 4 letras anteriores a 2ª letra da entrada (E -> A | A -> W) minúscula;
- 3º Caractere -> 6 letras anteriores a 3ª letra da entrada (G -> A | A -> T) minúscula;
- 4º Caractere -> '@';
- 5º, 6º, 7º e 8º caracteres -> 1ª, 2ª, 3ª e 4ª letras da entrada respectivamente seguindo o seguinte padrão: posição da letra no alfabeto (A -> 1, B -> 2), caso seja somente um digito, ele mesmo, se forem 2, multiplique-os e pegue o primeiro digito do resultado.

Caso seja marcado como senha forte, é adicionado "@hard" antes.

Exemplos:
-Entrada: "teste"
-Forte?: Não
-Saída: Ram.0590

-Entrada: "teste"
-Forte?: Sim
-Saída: @hardRam.0590

## Alerta

Esse é apenas um projeto teste, não é recomendado o uso real dele para gerenciar senhas!
