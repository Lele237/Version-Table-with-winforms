namespace TabelaVersoes;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

                Form janela = new Form ();
                janela.Text = "Controle de versões";
                janela.Size = new Size(750, 350);
                janela.StartPosition = FormStartPosition.CenterScreen;

                DataGridView tabela = new DataGridView();

                tabela.Dock =DockStyle.Fill;
                tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                tabela.ReadOnly = true;
                tabela.AllowUserToAddRows = false;
                tabela.RowHeadersVisible = false;
                tabela.Columns.Add("Tipo", "Tipo");
                tabela.Columns.Add("Exemplo", "Exemplo");
                tabela.Columns.Add("Significado", "Significado");

                tabela.Rows.Add("Major", "2.0.0", "Pode quebrar o código existente");
                tabela.Rows.Add("Minor", "1.3.0", "Adiciona novas funcionalidades");
                tabela.Rows.Add("Patch", "1.2.4", "Corrige bugs e problemas");

                janela.Controls.Add(tabela);
                
        Application.Run(janela);
    }    
}