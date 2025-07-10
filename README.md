# Trilha-Net-MVC-Desafio
# Trilha .NET - MVC e Entity Framework

# Trilha .NET - MVC e Entity Framework

## Desafio: Gerenciador de Tarefas - MVC

Este repositório contém a solução para o desafio proposto no módulo de **API e Entity Framework** da trilha .NET da [DIO](https://web.dio.me).

📷 **Imagem da Página de Tarefa**
<img width="1220" height="380" alt="ListaTarefas" src="https://github.com/user-attachments/assets/38673881-b229-46ca-b543-530faf6d5622" />

## 📌 Descrição do Projeto

O projeto consiste em um sistema **MVC** que permite gerenciar tarefas do dia a dia com as funcionalidades completas de um CRUD (Criar, Listar, Editar e Deletar).

O objetivo é aplicar os conceitos aprendidos em Entity Framework e ASP.NET MVC para construir uma aplicação prática e funcional.

---

## ✅ Funcionalidades

- ✅ 📷**Criar nova tarefa**
  <img width="631" height="532" alt="CadastrarTarefa" src="https://github.com/user-attachments/assets/4045c210-f909-409d-9511-364530652c36" />

- ✅ 📷**Editar tarefa existente**
- <img width="840" height="615" alt="Date" src="https://github.com/user-attachments/assets/013703d8-8bd3-4514-b2aa-18da6cdafa1e" />

- ✅ 📷**Deletar tarefa**
  <img width="877" height="455" alt="Deletar" src="https://github.com/user-attachments/assets/150e310a-29dc-4fe6-93b7-1ada53be70a1" />

- ✅ 📷**Listar todas as tarefas**
 <img width="1220" height="380" alt="ListaTarefas" src="https://github.com/user-attachments/assets/09fb52e8-a676-408f-b1ea-d9fb2fb11d69" />

- ✅ 📷**Filtrar tarefas por:**
  - Título
  - Data
  - Status

---

## 🧱 Estrutura da Classe Principal (`Tarefa`)

```csharp
public class Tarefa
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime Data { get; set; }
    public EnumStatusTarefa Status { get; set; }
}

