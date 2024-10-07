# OdontoPrev - Sistema de Gerenciamento e Detecção de Fraudes   :computer:
## Definição do Projeto
### Objetivo do Projeto
O objetivo deste projeto é desenvolver uma aplicação para a OdontoPrev, que gerencia as operações diárias envolvendo Pacientes, Dentistas, Clínicas, Agendamentos, Tabela Preco e Contas a Receber/Pagar. Além disso, o sistema detectará automaticamente possíveis fraudes financeiras e administrativas, facilitando a gestão e prevenindo atividades fraudulentas.

### Escopo
O projeto inclui as seguintes funcionalidades principais:

- Gerenciamento de Pacientes, Dentistas e Clínicas, Agendamento, Contas, Tabela Preço e Fraude: Cadastrar, visualizar, atualizar e excluir informações.
- Agendamentos: Registrar consultas entre pacientes e dentistas.
- Contas a Receber/Pagar: Gerenciar os pagamentos de consultas e procedimentos.
- Detecção de Fraudes: Identificar padrões de comportamento suspeitos, como múltiplos agendamentos em curtos períodos e valores anormais em contas.
### Requisitos Funcionais
- O sistema deve permitir o cadastro, leitura, atualização e exclusão (CRUD) de Pacientes, Dentistas, Clínicas, Agendamentos, Contas, Tabela Preço e Fraude.
- A aplicação deve permitir a consulta e visualização de relatórios de fraudes.
### Requisitos Não Funcionais
- O sistema deve seguir a Clean Architecture, garantindo modularidade e baixo acoplamento.
- Deve suportar tratamento de erros e validação dos dados.
- O sistema deve ser responsivo e eficiente no processamento das fraudes detectadas.
## Desenho da Arquitetura
### Clean Architecture
O sistema será desenvolvido seguindo a Clean Architecture, garantindo que o código seja organizado e cada camada tenha uma responsabilidade bem definida. Isso facilita a manutenção e escalabilidade do sistema no futuro.

### Camadas da Aplicação
#### Apresentação:

- Interface de usuário que interage com os serviços da aplicação.
- Justificativa: Separar a lógica de apresentação da lógica de negócio para facilitar futuras mudanças na interface.
#### Aplicação:

- Implementa os serviços e casos de uso da aplicação. Contém a lógica que conecta a interface de usuário com as regras de negócio.
#### Domínio:

- Contém os modelos principais do sistema, como Paciente, Dentista, Clínica, Agendamento, Contas a Receber/Pagar,Tabela Preço e Fraude.

#### Infraestrutura:

- Gerencia o acesso aos dados, incluindo o uso do Entity Framework Core para mapeamento de entidades e conexão com o banco de dados.
- Criado um listagem para simular o Banco de dados !
  
