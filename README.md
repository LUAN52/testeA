# teste feito para empresa AscSolution


DESAFIO

Você deverá criar um projeto Web para simular um período acadêmico com 3 turmas e exibir os valores obtidos por cada aluno em cada prova.

O backend da aplicação deverá ser feito em C# e a tecnologia do frontend é de livre escolha, mas sugerimos Angular JS com Bootstrap.

Regras

1. Deve haver 3 turmas, com exatamente 20 alunos em cada.

2. Cada aluno fará 3 provas, sendo que para realizar o cálculo da média final, as provas 2 e 3 possuem respectivamente pesos 20% e 40% maiores que a primeira.

3. A média final de cada aluno é obtida pela média ponderada das 3 provas. Se o aluno obtiver média final maior que 6 será aprovado, se a média final for abaixo de 4 será reprovado e caso a média esteja entre esses valores, o aluno deve fazer uma prova final que irá decidir sua aprovação ou reprovação. Com isso, ele será aprovado somente se a média da nota da prova final com a média ponderada das 3 primeiras provas for maior ou igual a 5.

4. Após o final de todas as provas, os 5 alunos que obtiverem as melhores médias finais devem ser selecionados para participar de uma competição para ganhar um prêmio. Nessa competição, esses alunos serão submetidos a uma prova especial.

5. O campeão da competição será o aluno que obtiver a maior média ponderada de todas provas feitas e a prova especial que terá peso 2. Mas nessa média final ponderada para definir o vencedor, os pesos de todas provas anteriores devem ser desconsiderados e deve ser incluído a prova final caso ela tenha sido feita pelo aluno em questão. Portanto, o cálculo será feito com todas provas realizadas no período com peso 1 e a prova especial da competição com peso 2.

Fluxo do programa:

1. Gerar 20 alunos para cada uma das 3 turmas.

2. Gerar uma simulação das notas nas 3 provas para cada aluno.

3. Verificar os aprovados e reprovados considerando as provas finais caso necessário.

4. Exibir informações de todos alunos com os resultados de todas as provas.

5. Exibir os 5 melhores alunos que participarão da competição.

6. Simular a nota da prova da competição e definir o vencedor.

 

Bônus

Salvar todas informações geradas em uma base de dados usando preferencialmente Entity Framework.
