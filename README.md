# dotnet-system

- Criando uma solução AspNet

dotnet new sln -o Journey

- Entrando na pasta do projeto

cd Journey/


- Criando uma WebApi

dotnet new webapi -o Journey


- Vinculando projeto à solução

dotnet sln add ./Journey/Journey.csproj 
 
 
- Comentar para funcionar com http

comment program.cs "//app.UseHttpsRedirection();"
 
 
 
- Executando o projeto

dotnet run --project journey
