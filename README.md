
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
├── Api
│   └── Api_Metrics_With_Prometheus.sln
│   └── Api_Metrics_With_Prometheus
│       ├── Controllers
│       ├── Models
│       ├── Program.cs
│       ├── Startup.cs
│       └── ...
├── docker-compose.yml
├── prometheus.yml
├── grafana
├── DataBaseVolume/data
│   
└── README.md
```

## Configuração

1. Clone o repositório:

   ```bash
   git clone https://github.com/GeuberLucas/Observability_and_monitoring_application.git
   cd Observability_and_monitoring_application
   ```


## Executando a Aplicação

Para iniciar todos os serviços, execute o comando:

```bash
docker-compose build
docker-compose up -d
```

Isso iniciará os containers da API, do banco de dados, do Prometheus e do Grafana.

## Acessando o Swagger

Após iniciar a aplicação, você pode acessar a documentação da API pelo Swagger no seguinte endereço:

```
http://localhost:8090/swagger
```

## Monitoramento com Prometheus e Grafana

- **Prometheus**: Acesse o Prometheus em `http://localhost:8091`.
- **Grafana**: Acesse o Grafana em `http://localhost:8092`. As credenciais padrão são `admin` para usuário e `admin` para senha.


## Parando e Removendo os Containers

Para parar e remover os containers, execute:

```bash
docker-compose down
```

## Licença

Este projeto está licenciado sob a [MIT License](./LICENSE).

---

Este README serve como ponto de partida para seu repositório e pode ser personalizado conforme as necessidades do seu projeto.
