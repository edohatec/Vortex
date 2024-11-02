sequenceDiagram
actor Usuário
participant UI as frontend
participant AuthService as backend
participant DB as Base de Dados

    Usuário ->> UI: Insere e envia credenciais de login
    UI ->> AuthService: {Email, Senha}
    AuthService ->> DB: Valida e busca usuário
    DB -->> AuthService: Retorna confirmação (credenciais válidas)
    AuthService ->> UI: Retorna token de sessão e mensagem de sucesso
    UI ->> Usuário: Exibe mensagem de boas-vindas e redireciona
