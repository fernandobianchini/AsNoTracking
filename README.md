# Benchmark de uso do AsNoTracking() no Entity Framework

Este � o projeto AsNoTracking, que demonstra o uso do m�todo AsNoTracking() do Entity Framework em consultas.

## Configura��o do ambiente

### Pr�-requisitos

Certifique-se de ter os seguintes pr�-requisitos instalados em sua m�quina:

- Docker Desktop: [https://www.docker.com/products/docker-desktop](https://www.docker.com/products/docker-desktop)

### Configurando o ambiente usando Docker

Para executar o projeto, voc� pode usar um cont�iner Docker do SQL Server para criar o banco de dados. Siga as etapas abaixo:

1. Abra o Docker Desktop em sua m�quina.

2. No terminal ou prompt de comando, execute o seguinte comando para criar um cont�iner Docker com o SQL Server:

```shell
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Your_Password123" -p 1433:1433 --name my-sqlserver -d mcr.microsoft.com/mssql/server:2019-latest
```

Certifique-se de substituir "Your_Password123" por uma senha forte de sua escolha.

3. Aguarde alguns instantes at� que o cont�iner seja baixado e iniciado. Voc� pode verificar o status do cont�iner executando o seguinte comando:

```shell
docker ps
```

## Executando o projeto

1. Abra o projeto AsNoTracking em sua IDE de escolha.

2. Atualize a string de conex�o no arquivo `appsettings.json` para refletir a configura��o do SQL Server. Exemplo:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=Produtos;User Id=sa;Password=Your_Password123;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=False;"
}
```

Certifique-se de substituir "Your_Password123" pela senha que voc� escolheu ao configurar o cont�iner.

3. Compile e execute o projeto. Agora voc� pode explorar e testar o uso do m�todo AsNoTracking() em consultas do Entity Framework.
