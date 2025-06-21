
# 🕒 Timeout Tools

Este repositório contém dois aplicativos simples desenvolvidos em C#: um para linha de comando (**Timeout_Lsp_Cmd**) e outro com interface gráfica Windows Forms (**Timeout_Lsp**). Ambos executam uma contagem regressiva baseada em um tempo informado.

---

## 🕒 Timeout_Lsp_Cmd

### ✔️ Descrição
Aplicativo de console em C# que executa uma contagem regressiva em segundos, recebendo o tempo como argumento. A cada segundo, exibe no console o tempo restante, limpando a tela a cada atualização. Definido por padrão (2 segundos).

### 🚀 Como usar

#### ✅ Compilação
Compile o projeto com Visual Studio, Rider ou via terminal com:

```bash
csc Program.cs
```

#### ✅ Execução
Execute o programa passando o tempo desejado em segundos como argumento:

```bash
Timeout_Lsp_Cmd.exe 5
```

#### 🔗 Exemplo de saída:

```
Aguardando... 05 segundos.
Aguardando... 04 segundos.
...
Aguardando... 01 segundo.
```

### ⚠️ Observações
- Se não passar argumento ou passar um valor inválido, o programa exibirá uma mensagem de uso correto.
- Se passar mais de um argumento, ele também exibirá erro.

---

## 🕒 Timeout_Lsp (Interface Gráfica - Windows Forms)

### ✔️ Descrição
Aplicação Windows Forms que executa uma contagem regressiva em segundos, exibindo na interface o tempo restante. O tempo pode ser passado como argumento na linha de comando ou definido por padrão (2 segundos).

### 🖥️ Como usar

#### ✅ Compilação
Abra o projeto no Visual Studio e compile normalmente.

#### ✅ Execução

Execute o aplicativo passando o tempo em segundos como argumento (opcional):

```bash
Timeout_Lsp.exe 5
```

- **Sem argumento:** Usará o valor padrão de 2 segundos.

### 🔗 Funcionamento
- Uma janela é exibida com o rótulo `Aguardando...`.
- A cada segundo, o contador diminui.
- Ao chegar em 0, o aplicativo fecha automaticamente.

### 🎯 Interface

| Tempo Restante | Label exibido                      |
|----------------|-------------------------------------|
| Maior que 1    | Aguardando 05 segundos             |
| Igual a 1      | Aguardando 01 segundo              |
| Igual a 0      | Fecha automaticamente              |

---

## 🛠️ Tecnologias utilizadas

- .NET Framework
- C#
- Windows Forms (para Timeout_Lsp)
- Console Application (para Timeout_Lsp_Cmd)

---

## 👨‍💻 Autor

- **Maycon Wisley**  
🔗 [LinkedIn](https://www.linkedin.com/in/mayconwisley/)
