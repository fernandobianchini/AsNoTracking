# Benchmark de uso do AsNoTracking() no Entity Framework

Este é o projeto AsNoTracking, que demonstra o uso do método AsNoTracking() do Entity Framework em consultas.

## Configuração do ambiente

### Pré-requisitos

Certifique-se de ter os seguintes pré-requisitos instalados em sua máquina:

- Docker Desktop: [https://www.docker.com/products/docker-desktop](https://www.docker.com/products/docker-desktop)

### Configurando o ambiente usando Docker

Para executar o projeto, você pode usar um contêiner Docker do SQL Server para criar o banco de dados. Siga as etapas abaixo:

1. Abra o Docker Desktop em sua máquina.

2. No terminal ou prompt de comando, execute o seguinte comando para criar um contêiner Docker com o SQL Server:

```shell
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Your_Password123" -p 1433:1433 --name my-sqlserver -d mcr.microsoft.com/mssql/server:2019-latest
```

Certifique-se de substituir "Your_Password123" por uma senha forte de sua escolha.

3. Aguarde alguns instantes até que o contêiner seja baixado e iniciado. Você pode verificar o status do contêiner executando o seguinte comando:

```shell
docker ps
```

## Executando o projeto

1. Abra o projeto AsNoTracking em sua IDE de escolha.

2. Atualize a string de conexão no arquivo `appsettings.json` para refletir a configuração do SQL Server. Exemplo:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=Produtos;User Id=sa;Password=Your_Password123;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=False;"
}
```

Certifique-se de substituir "Your_Password123" pela senha que você escolheu ao configurar o contêiner.

3. Compile e execute o projeto. Agora você pode explorar e testar o uso do método AsNoTracking() em consultas do Entity Framework.
