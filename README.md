# Exercise_Composition_Enum_RegisterSystem
<p>Projeto de exercício de fixação utilizando os conceitos de composição e enumeração em Orientação a Objetos na linguagem C# .NET 6.</p>
<p>Neste exercício, o usuário deve entrar com o nome do seu departamento e, em seguida, entrar com seus dados (nome, nível, salário base). 
  Posteriormente, deve informar a quantidade de contratos e informar os dados de cada contrato (data, valor por hora e duração em horas).</p>
<p>Por fim, informar o mês e o ano que deseja saber qual foi sua renda.</p>
<p>Para solução desse exercício, foram criadas três classes (Worker, HourContract e Department) e uma enum (WorkerLevel). Dessa forma, na classe Worker, existem duas composições e uma enumeração, nas quais: com a classe HourContract é uma relação "tem-vários", com a classe Department é uma relação "tem-um" e, por fim, o atributo Level é do tipo WorkerLevel, sendo uma enumeração.</p>

![image](https://user-images.githubusercontent.com/80121288/170869329-ee34693d-303b-470f-9f45-71f9fd6e6c4a.png)
