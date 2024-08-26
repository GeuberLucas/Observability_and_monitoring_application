Aqui está um exemplo de um arquivo README para o seu repositório:

---

# Projeto de Monitoramento de Aplicação com Docker Compose

Este projeto é uma aplicação C# que implementa uma API com operações CRUD para o registro de pessoas. A aplicação é monitorada utilizando Prometheus e Grafana, com todos os serviços orquestrados em containers via Docker Compose. O projeto também inclui um banco de dados SQL e usa Swagger para documentação da API.

## Índice

- [Pré-requisitos](#pré-requisitos)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Configuração](#configuração)
- [Executando a Aplicação](#executando-a-aplicação)
- [Acessando o Swagger](#acessando-o-swagger)
- [Monitoramento com Prometheus e Grafana](#monitoramento-com-prometheus-e-grafana)
- [Parando e Removendo os Containers](#parando-e-removendo-os-containers)
- [Licença](#licença)

## Pré-requisitos

Antes de começar, certifique-se de ter o seguinte instalado em sua máquina:

- [Docker](https://www.docker.com/)
- [Docker Compose](https://docs.docker.com/compose/)
- [Git](https://git-scm.com/)

## Estrutura do Projeto

```plaintext
├── src
│   └── Api
│       ├── Controllers
│       ├── Models
│       ├── Program.cs
│       ├── Startup.cs
│       └── ...
├── docker-compose.yml
├── prometheus
│   └── prometheus.yml
├── grafana
│   └── provisioning
│       └── dashboards
│           └── dashboard.json
└── README.md
```

## Configuração

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio
   ```

2. Crie um arquivo `.env` na raiz do projeto e defina as variáveis de ambiente necessárias (como conexão com o banco de dados).

## Executando a Aplicação

Para iniciar todos os serviços, execute o comando:

```bash
docker-compose up -d
```

Isso iniciará os containers da API, do banco de dados, do Prometheus e do Grafana.

## Acessando o Swagger

Após iniciar a aplicação, você pode acessar a documentação da API pelo Swagger no seguinte endereço:

```
http://localhost:5000/swagger
```

## Monitoramento com Prometheus e Grafana

- **Prometheus**: Acesse o Prometheus em `http://localhost:9090`.
- **Grafana**: Acesse o Grafana em `http://localhost:3000`. As credenciais padrão são `admin` para usuário e `admin` para senha.

Dentro do Grafana, você pode importar o dashboard localizado em `grafana/provisioning/dashboards/dashboard.json`.

## Parando e Removendo os Containers

Para parar e remover os containers, execute:

```bash
docker-compose down
```

## Licença

Este projeto está licenciado sob a [MIT License](./LICENSE).

---

Este README serve como ponto de partida para seu repositório e pode ser personalizado conforme as necessidades do seu projeto.
