﻿using System;
using System.Windows.Forms;
using Warden.View.Cliente;

namespace Warden.View
{
    public partial class UscCliente : UscBase
    {
        public UscCliente()
        {
            InitializeComponent();
        }

        private void UscCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            UscClienteCadastro CadastrarCliente;
            try
            {
                CadastrarCliente = new UscClienteCadastro();
                CreateNewControl(CadastrarCliente);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            UscClientePesquisar PesquisarCliente;
            try
            {
                PesquisarCliente = new UscClientePesquisar();
                CreateNewControl(PesquisarCliente);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }
    }
}
