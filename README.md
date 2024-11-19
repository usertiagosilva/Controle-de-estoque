# Controle de Estoque 🛒

![controle de estoque](https://github.com/user-attachments/assets/09b01495-6a0b-4604-9433-0d5017973179)


## 🎯 Objetivo
Desenvolver um aplicativo de controle de estoque que permita gerenciar produtos em um banco de dados MySQL. O aplicativo possibilita adicionar, editar, remover e visualizar informações sobre produtos em estoque, como nome, quantidade e preço.

---

## ✨ Funcionalidades
- **Adicionar Produto**: Insira novos produtos no estoque.
- **Editar Produto**: Atualize informações de produtos existentes.
- **Remover Produto**: Exclua produtos do estoque.
- **Visualizar Estoque**: Veja a lista completa de produtos em estoque.
- **Pesquisar Produto**: Encontre produtos específicos na lista.
- **Limpar Campos**: Resete os campos de entrada e a pesquisa.

---


### 2. **Configuração do Banco de Dados MySQL**
- Crie um banco de dados com uma tabela para armazenar as informações dos produtos:
  ```sql
  CREATE TABLE produtos (
      id INT AUTO_INCREMENT PRIMARY KEY,
      nome VARCHAR(100) NOT NULL,
      quantidade INT NOT NULL,
      preco DECIMAL(10, 2) NOT NULL
  );

