# Prototype-Control-of-Muscle-Tension-Flywheel
This project is a prototype for control of muscle tension for equipaments of Flywheel. This project isn't connect with database, because it is a prototype for presentation. The objective this project is control and to view muscle tension for gym equipaments. So, personal trainer can extract informations about muscle tension for better conduct training.

# Environment
The project consists of a C# Windows Forms application.

# Settings
After cloning this project in your development environment, some initial configurations will be necessary for the program to run without errors.

## User and Password
In the Formularios folder in frm_login.cs on the 27 line you will can change the parameters for user and password for enter in principal system:

```C#
private void btn_entrar_Click(object sender, EventArgs e)
{
    if(txtbox_senha.Text == "admin" && txtbox_user.Text == "admin")
    {
        frm_inicio novo = new frm_inicio();
        this.Hide();
        novo.Show();
    }
}
```

# Versão em Português

# Prototipo-Controle-de-Tensao-Muscular-Flywheel
Este projeto é um protótipo para controle de tensão muscular para equipamentos da Flywheel. Este projeto não possui banco de dados, pois é um protótipo para apresentação. O objetivo deste projeto é controlar e visualizar a tensão muscular para equipamentos de academia. Assim, o personal trainer pode extrair informações sobre tensão muscular para melhor conduzir o treinamento.

# Ambiente
O projeto consiste em uma aplicação C# Windows Forms.

# Configurações
Após clonar esse projeto em seu ambiente de desenvolvimento, será necessário algumas configurações iniciais para que a execução do programa seja efetuada sem erros.

## Usuário e Senha
Na pasta Formularios em frm_login.cs na 27ª você poderá definir uma senha e um usuário para entrar no sistema principal:

```C#
private void btn_entrar_Click(object sender, EventArgs e)
{
    if(txtbox_senha.Text == "admin" && txtbox_user.Text == "admin")
    {
        frm_inicio novo = new frm_inicio();
        this.Hide();
        novo.Show();
    }
}
```
