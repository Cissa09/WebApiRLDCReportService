<h4 align="center"> 
	🚧 ASP.NET Core API Report Service 🚀 em construção... 🚧
</h4>

<p align="center">
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/Cissa09/WebApiRLDCReportService?color=%2304D361">

  <img alt="Repository size" src="https://img.shields.io/github/repo-size/Cissa09/WebApiRLDCReportService">
  	  	  
  <a href="https://github.com/tgmarinho/nlw1/commits/master">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/Cissa09/WebApiRLDCReportService">
  </a>  
</p>


## 💻 Sobre o projeto

Muitos softwares legados iniciados no inicio da década ficam refens de ferramentas para gerar relatórios que muitas vezes não acompanham o crescimento do negócio e tão pouco o Roadmap do produto. Desta forma este projeto fornece uma alternativa moderna de criar relatórios que podem evoluir para serviços ou simplesmente atender a demanda do seu negócio.

Este projeto cria um relatório a partir de um DataSource vinculado a um banco de dados. 
Este projeto já consta dentro de um Design pattern DDD respeitando na modelagem os atributos de negócio.

## 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

- [ASP.NET Core][asp.net core]
- [Microsoft RDLC Report][rdlc]
- [Visual Studio 2022][vs22]

## ☁️ Dependências do projeto

1. AspNetCore.Reporting 2.1.0
2. Microsoft.EntityFrameworkCore 5.0.1
3. Microsoft.EntityFrameworkCore.SqlServer 5.0.1
4. System.CodeDom 4.7.0
5. System.Configuration.ConfigurationManager 6.0.0
6. System.Data.SqlClient 4.8.2

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Visua Studio 2022][vs22]. 
Além disto como o Visual Studio 2022 não trás o Micrososf RDLC Report como padrão como seu antecessor o Visual Studio 2019, você vai precisar instalar este via marketplace [Microsoft RDLC Report Designer 2022][rdlcdonwload]

### 🎲 Fazendo o projeto funcionar

Para a parte não colaborativa deste projeto crie um WindowsFormApplication, ele será responsável por criar seus reports .rdlc.

<a href="https://imgbb.com/"><img src="https://i.ibb.co/JQMb1Lm/add-wfapp2.png" alt="add-wfapp2" border="0"></a>

e crie seus proprios reports:

<a href="https://ibb.co/XSKZp4h"><img src="https://i.ibb.co/0h6jZXg/add-Report.png" alt="add-Report" border="0"></a><br /><a target='_blank' href='https://pt-br.imgbb.com/'></a><br />

Para comunicar com seu banco de dados, você dá dois clicks no relatório .rdlc que você criou anteriormente e adiciona um novo DataSet:

<a href="https://imgbb.com/"><img src="https://i.ibb.co/CnZ0B4P/add-Ds.png" alt="add-Ds" border="0"></a>

Considerando que este dataset tenha uma fonte correta (DataSource) a visualização que você terá depois de ter configurado corretamente será semelhante a esta:

![image](https://user-images.githubusercontent.com/26122083/162359391-c14b56d9-75c6-4d47-ab4d-86c1e8fdfd30.png)

Feito isto basta você copiar seu report .rdlc para a a pasta wwwroot/Reports do projeto colaborativo.

A conexão com banco é feita por injeção de dependência na classe startup.cs. 

Para montar sua connectionString, basta preencher as variáveis SERVER, DATABASE, USERDB e PASSWORDUSER que se encontram no appsettings.json, que por motivos de segurança encontra-se em branco.

Cuide para não divulgar seus dados em algum Pull Request.

Esta é a cara final da Solution:

![image](https://user-images.githubusercontent.com/26122083/162359789-59007792-34ed-4274-9121-8c1f0a1f2786.png)

OBS: Para não depender de um dataset oriundo do projeto não colaborativo, basta criar um DataTable e preenchelo manualmente antes de executar o Print();

## 😯 Como contribuir para o projeto

1. Faça um **fork** do projeto.
2. Crie uma nova branch com as suas alterações: `git checkout -b my-feature`
3. Salve as alterações e crie uma mensagem de commit contando o que você fez: `git commit -m "feature: My new feature"`
4. Envie as suas alterações: `git push origin my-feature`
> Caso tenha alguma dúvida confira este [guia de como contribuir no GitHub](https://github.com/firstcontributions/first-contributions)

## 📝 Licença

Este projeto esta sobe a licença MIT.

Feito com ❤️ por Cicero de Azevedo Viganon 👋🏽 [Entre em contato!](https://www.linkedin.com/in/cicero-de-azevedo-viganon-64b20224/)

[asp.net core]: https://docs.microsoft.com/pt-br/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0/
[rdlc]: https://docs.microsoft.com/pt-br/sql/reporting-services/create-drillthrough-rdlc-report-with-parameters-reportviewer?view=sql-server-ver15/
[vs22]: https://visualstudio.microsoft.com/pt-br/vs/
[rdlcdonwload]: https://marketplace.visualstudio.com/items?itemName=ProBITools.MicrosoftRdlcReportDesignerforVisualStudio2022/
