## Teste-dev-dotNet-Brq

# Criando o servidor (No cmd)
sqllocaldb create "LocalDbTruck"

# Servidor
(LocalDb)\LocalDbTruck

# Depêndencias (EntityFrameworkCore 5.0.0 e .Net Core 3.1)
Swashbuckle.AspNetCore (Versão 6.2.3)
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer

# Criar base de dados
Add-Migrations NomePrimeiraMigration
Update-Database

# Observações
Muita coisa poderia ter sido feita de uma maneira melhor.
Mas, como não dispunha de muito tempo, fiz da maneira mais básica possível.

Por exemplo... Para dar melhor precisão aos testes de integração e unidade,
poderia ter sido usado o o pacote nuget Moq e o FluentAssertion (pelo menos).
Na estrutura da aplicação, poderia ter dividido as reposabilidades em mais
camadas. Isolando assim bem cada responsabilidade. Poderia ter se configurado
um logging também.
No que se refere a banco de dados, poderia ter automatizado o migrations
para rodar a cada alteração e vez que o Visual Studio rodasse. Além da falta
de um auto mapper.
E por último, poderia terem sido configuradas as depêndencias em um container
Docker. CI/CD não seria interessantes nesse teste, pois o mesmo deve rodar
localmente.
Enfim... É isso!