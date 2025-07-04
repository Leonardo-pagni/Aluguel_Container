📦 Projeto Aluguel_Container
Projeto desenvolvido com foco em aprendizado e conclusão de curso sobre Arquitetura Limpa no ecossistema .NET.

A solução segue o padrão de camadas proposto pela arquitetura limpa, sendo estruturada em:

Domínio – Contém as entidades e regras de negócio essenciais da aplicação.

Aplicação – Responsável pelos casos de uso e orquestração das operações do sistema.

Infraestrutura – Implementa os repositórios, serviços de persistência e acesso a dados.

Interface (Web API) – Camada de apresentação, onde são expostos os endpoints REST.

Funcionalidades implementadas:

Tela de cadastro de clientes

Endpoint POST api/registros para cadastrar um novo cliente

Endpoint GET /api/clientes para listar os clientes cadastrados

Este projeto demonstra a separação clara de responsabilidades entre as camadas, facilitando a manutenção, escalabilidade e testabilidade da aplicação.
