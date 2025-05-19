C#

.NET

Windows Forms

📌 Visão Geral
O Academic Task Manager é um sistema de gerenciamento de tarefas acadêmicas (baseado no gitlab) desenvolvido em C#/.NET com Windows Forms, criado para auxiliar estudantes e professores no acompanhamento de projetos e prazos acadêmicos.

✨ Funcionalidades Principais

✅ Gerenciamento de Tarefas

Cadastro de tarefas com título, descrição e data de entrega

Marcação de tarefas concluídas

Filtros por projeto e status

✅ Controle de Projetos

Criação de projetos acadêmicos

Vinculação de tarefas a projetos

Acompanhamento de progresso

✅ Interface Intuitiva

Design limpo e fácil de usar

Visualização em lista e calendário

Lembretes de prazos próximos

🛠 Tecnologias Utilizadas
Linguagem: C# 10

Framework: .NET 6.0

Interface: Windows Forms

Padrões: Repository Pattern, Dependency Injection

Ferramentas: Visual Studio Code, Git, GitHub

🚀 Como Executar
Pré-requisitos
.NET 6.0 SDK

# Clone o repositório
git clone https://github.com/OtavioPereir4/AcademicTaskManager.git
cd AcademicTaskManager

# Restaure as dependências
dotnet restore

# Execute o projeto
dotnet run --project GUI/GUI.csproj
📂 Estrutura do Projeto
AcademicTaskManager/
├── Core/           # Lógica de negócio
│   ├── Models/     # Entidades (Tarefa, Projeto, Usuário)
│   ├── Services/   # Regras de negócio
│   └── Repositories/ # Acesso a dados
│
├── GUI/            # Interface gráfica
│   ├── Forms/      # Formulários Windows
│   ├── Controls/   # Componentes visuais
│   └── Program.cs  # Ponto de entrada
│
└── AcademicTaskManager.sln  # Solução Visual Studio
